qrScanning = false;

setTimeout(onEveryTick, 10000);

btn.onclick = function(){
    qrScanning = true;
    var html5QrcodeScanner = new Html5QrcodeScanner(
        "reader", { fps: 10, qrbox: 250 });
            
    function onScanSuccess(decodedText, decodedResult) {
        // Handle on success condition with the decoded text or result.
        console.log(`Scan result: ${decodedText}`, decodedResult);
        occupySlot(decodedText);
        qrScanning = false;
        // ...
        html5QrcodeScanner.clear();
        // ^ this will stop the scanner (video feed) and clear the scan area.
    }
    
    html5QrcodeScanner.render(onScanSuccess);
}

function sendXML(task, sendData, returnFunc, phpLocation="./kiosk.php") {
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
};

function onEveryTick() {
    if (!qrScanning) {
        location.reload(true);
    }
}

function occupySlot(data) {

        serializedData = JSON.parse(data);
        sendXML('pendoccupy', serializedData[0], reload, "../home/booking.php");

}

function reload(data) {
    location.reload(true);
}

function gotData(data) {
    text = "";
    var today= new Date();
    console.log(data);

    text = "Please login to metroparking.com to book this slot...";
    btn.disabled = true;
    btn.textContent = "Scan QR Code";

    if (data != '0') {
        parsedData = JSON.parse(data);
        var bookDate= new Date(parsedData[3]);
        if (parsedData[6] == '0') {
            if ((today.getDate() === bookDate.getDate()) && ((Number(parsedData[4]) <= today.getHours()) && (today.getHours() <= (Number(parsedData[4]) + Number(parsedData[5]))))) {
                text = "This slot is already booked. If you booked this slot, please click on Scan QR Code to occupy the space...";
                btn.disabled = false;
                btn.textContent = "Scan QR Code";
            }
            console.log(Number(parsedData[4]), (Number(parsedData[4]) + Number(parsedData[5])), today.getHours());
        } else if (parsedData[6] == '1') {
            text = "This slot is already booked. If you're already occupying the space, plase log into your account and click on Unoccupy to exit the parking space...";
            btn.disabled = true;
            btn.textContent = "Scan QR Code";
        } else if (parsedData[6] == '4') {
            text = "Please remove your vehicle from the slot to complete...";
            btn.disabled = true;
            btn.textContent = "Scan QR Code";
        }
        else if (parsedData[6] == '5') {
            text = "Please back your vehicle until the indicator turns off...";
            btn.disabled = true;
            btn.textContent = "Scan QR Code";
        }
    }
    document.getElementById('text').innerText = text;
}

sendXML('getbooking', '1', gotData);