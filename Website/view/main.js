const btn = document.getElementById('btn');

// ID of the user

myID = 0;
// ID of the profile user is viewing
bookingExist = false;
bookingID = 0;
bookingStatus = '0';

/////////////////////////////////////////////////////////////////////////
// Separating the link and extracting its content
// Note: If the link comes with a separate ?word parameter, then we specifically
// try to get that word. On every other case, a random word is taken.
//
let userlink = window.location.href; //Link we got when user clicked on the link
let mylink = window.location.pathname; //Link where the website actually reside

////////////////////////////////////////////////////////////////////////////////
// Functions

btn.onclick = function(){
    if (bookingStatus == "1") {
        sendXML('pendunoccupy', bookingID, gotError, "../home/booking.php");
    } else {
        sendXML('cancelbooking', bookingID, gotError, "../home/booking.php");
    }
}

function gotError(error) {
    window.location.replace("../home");
}

function sendXML(task, sendData, returnFunc, phpLocation="./profile.php") {
    // Function to send XML requests to php and accept data
    // Accepts (string)task that gives the task to complete, (string)sendData that contain the data to send
    // (function) returnFunc that give what function to use when reply is recieved, optional (string)phpLocation
    // that specify which php to send POST to (default='voting.php')
    // Returns null
    //
    var data = new FormData();
    data.append('task', task);
    data.append('data', sendData);

    xmlhttp = new XMLHttpRequest();
    // Sending the submitted data to the phpLocation file as POST data
    //
    xmlhttp.open("POST",phpLocation, true);
    xmlhttp.onreadystatechange=function(){
        if (xmlhttp.readyState == 4){
            if(xmlhttp.status == 200){
                // When a reply is recieved, call the returnFunc function
                // transfering the XML reply (xmlhttp.response) to it
                //console.log(xmlhttp.response);
                returnFunc(xmlhttp.response);
            }
        }
    };
    xmlhttp.send(data);
}

function displayBooking(result) {
    console.log(result);
    var booking = JSON.parse(result);
    var today= new Date();
    var bookDate= new Date(booking[3]);
    var text = "";

    if ((today.getDate() === bookDate.getDate()) && ((Number(booking[4]) <= today.getHours()) && (today.getHours() <= (Number(booking[4]) + Number(booking[5]))))) {
        if (booking[6] == "0") {
            text = "You can now occupy the parking slot. Scan the below QR code at the kiosk";
            new QRCode(document.getElementById("qrcode"), result);
            btn.disabled = true;
        } else {
            text = "Please click on Unoccupy to unoccupy the slot.";
            btn.disabled = false;
            btn.textContent = "Unoccupy";
        }
        
    } else {
        text = 'Booking made on ' + booking[2] + "\n" + "for Slot ID " + booking[1] + "\n" + "from " + booking[3] + " " + booking[4] + ".00 to " + (Number(booking[4]) + Number(booking[5])) + ".00";
    }
    document.getElementById('text').innerText = text;
    bookingID = booking[0];
    bookingStatus = booking[6];
}

function gotMyID(id) {
    // When an ID is recieved from the POST
    // Accept (string)id
    // Return null
    //
    if (id != "None") {
        // If not we check if the link contain a word or no
        myID = Number(id);
        sendXML('getbooking', id, displayBooking, "../home/booking.php");
    }
    else
    {
        window.location.replace("../signup");
    }
}

// End of functions. Start of code
/////////////////////////////////////////////////////////////////////////////////

sendXML('getId', '0', gotMyID, "../home.php");

// Sends a POST to get the ID of the user