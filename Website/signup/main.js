/* This is the Signup/Login webpage.
This webpage loads when the user clicks on a link or enter link to Login and signup forms.
The user can create a new account or login to an existing account from here. */

// Note: This JS calls the login.php and signup.php files and sit in /signup/ folder

/////////////////////////////////////////////////////////////////////////
// Separating the link and extracting its content
// Note: If the link comes with a separate ?signup parameter, then we specifically
// switch to the signup page. On every other case, the login page is given.
//
let userlink = window.location.href; //Link we got when user clicked on the link
let mylink = window.location.pathname; //Link where the website actually reside

if (userlink.split(mylink)[1] === "?signup") {
    // Checking if link contain the ?signup parameter and if so, switch forms
    const loginForm = document.querySelector("#login"); //Login form
    const signupForm = document.querySelector("#signup"); //Signup form

    loginForm.classList.add("form--hidden");
    signupForm.classList.remove("form--hidden");
}

function sendXML() {
    var data = new FormData();
    data.append('task', 'abortSession');

    xmlhttp = new XMLHttpRequest();
    // Sending the submitted data to the reset.php file as POST data
    //
    xmlhttp.open("POST","../home.php", true);
    xmlhttp.onreadystatechange=function(){
        if (xmlhttp.readyState == 4){
            if(xmlhttp.status == 200){
                // When a reply is recieved, call the gotReply function
                // transfering the XML reply (xmlhttp.response) to it
                console.log(xmlhttp.response);
            }
        }
    };
    xmlhttp.send(data);
}

sendXML();

// End of code. Start of event listeners.
/////////////////////////////////////////////////////////////////////////

document.addEventListener("DOMContentLoaded", () => {
    // On content load complete event. At this point, all other event listeners are loaded
    const loginForm = document.querySelector("#login"); //Login form
    const signupForm = document.querySelector("#signup"); //Signup form

    document.querySelector("#linkSignup").addEventListener("click", e => {
        // On click of Signup link (ID=linkSignup), show signup form
        e.preventDefault();
        loginForm.classList.add("form--hidden");
        signupForm.classList.remove("form--hidden");
    });

    document.querySelector("#linkLogin").addEventListener("click", e => {
        // On click of login link (ID=linkLogin), show login form
        e.preventDefault();
        loginForm.classList.remove("form--hidden");
        signupForm.classList.add("form--hidden");
    });

    document.querySelector("#userpages").addEventListener("click", e => {
        // On click of password reset/verification link (ID=userpages)
        // If the link text reads 'Resend verification code', then the mail page is opened
        // else the mail page is opened with ?pword= parameter
        // Note: The mail page handles all the mailing work. If it recieves no parameters, it
        // assumes user verification is the function, else if ?pword= parameter is recieved,
        // it switches to password reset mode. Refer to mail section for details.
        //
        e.preventDefault();
        if (document.getElementById("userpages__click").text === "Resend verification code") {
            window.location.replace("../mail");
        } else {
            window.location.replace("../mail?pword=");
        }
    });

    // **** LOGIN FORM ****
    loginForm.addEventListener("submit", e => {
        // On click of submit button in the login form
        e.preventDefault();

        // Switches to loading animation and disable the button
        const buttonElement = loginForm.querySelector(".form__button"); //Button element
        buttonElement.classList.add("form__button--loading");
        buttonElement.disabled = true;

        // Retrieving form data
        const formData = new FormData(login);
        // Call check email and password functions to verify them
        // **** IMPORTANT ****
        // Make sure to implement these in php as well to prevent attacks
        //
        check = checkEmail(document.getElementById("email").value);
        check = check && checkPassword(document.getElementById("password").value);

        if (check) {
            // Continuing if the data are valid
            // Sending the submitted data to the login.php file as POST data
            fetch('./login.php', {
                method: 'post',
                body: formData
            }).then(function(response) {
                // Once a response is recieved
                console.log(response);
                return response.text().then(function(text) {
                    // Extracting the returned text from POST reply
                    return text.split('"')[1];
                })
            }).then(function(text) {
                // Once data is recieved, tests to validate errors
                //
                // ERROR CODES-------------
                // <verified> - The user is verified and credentials are correct. Can log in
                // <notverified> - The user is not verified. Have to show the resend verification link
                // <error> - Any other error(Including wrong credentials. This is to protect user data)
                // -----------------------
                //
                // Button is set to normal
                buttonElement.classList.remove("form__button--loading");
                buttonElement.disabled = false;
                if (text === "<notverified>") {
                    // If email is not verified, the Reset password link is switched to Resend verification link
                    // Error message is also shown on message text
                    setFormMessage(login, "error", "This email is not verified.");
                    document.getElementById("userpages__click").text = "Resend verification code";
                } else if (text === "<verified>"){
                    // User verified and valid credentials. Can login the user
                    setFormMessage(login, "success", "Successfully logged in.");
                    
                    window.location.href = '../home/';
                    // IMPORTANT-----------------
                    // Once this stage is reached, the user must be taken to the voting page.
                    // Since for now, these pages don't exist, this area is left blank
                    // and nothing happens further.
                    // ****MAKE SURE TO ADD AUTHENTICATION PASSING AND REDIRECTING CODE HERE****
                    ////////////////////////////////////////////////////////////////////////////
                }
                else {
                    // On error code recieved, display the error message returned by PHP
                    setFormMessage(login, "error", text);
                }
            }).catch(function(error) {
                // In case JS encountered an error, display this error
                setFormMessage(loginForm, "error", "Oops! Something went wrong. Please reload the page.");
            })
        } else {
            // In case the entered doesn't match criteria, show this error [Defined in documents]
            buttonElement.classList.remove("form__button--loading");
            buttonElement.disabled = false;
            setFormMessage(loginForm, "error", "Invalid credentials");
        }
    });
    
    // **** SIGNUP FORM****
    signupForm.addEventListener("submit", e => {
        // On click of submit button of the signup form
        e.preventDefault();
        
        // Switch to loading animation and disable the button
        const buttonElement = signupForm.querySelector(".form__button");
        buttonElement.classList.add("form__button--loading");
        buttonElement.disabled = true;

        // Retrieving form data
        const formData = new FormData(signup);
        console.log(formData);
        // Call check email and password functions to verify them
        // **** IMPORTANT ****
        // Make sure to implement these in php as well to prevent attacks
        //
        check = checkUsername(document.getElementById("signupUsername").value);
        check = check && checkEmail(document.getElementById("signupEmail").value);
        check = check && checkPassword(document.getElementById("signupPassword").value);
        // Note: If the two password fields have the same text is also checked here(below)
        check = check && (document.getElementById("signupPassword").value === document.getElementById("signupConfirmPassword").value);

        if (check) {
            // Continuing if the data are valid
            // Sending the submitted data to the signup.php file as POST data
            fetch('./signup.php', {
                method: 'post',
                body: formData
            }).then(function(response) {
                // Once a response is recieved
                console.log(response);
                return response.text().then(function(text) {
                    // Extracting the returned text from POST reply
                    // console.log(text);
                    return text.split('"')[1];
                })
            }).then(function(text) {
                // Once data is recieved, tests to validate errors
                //
                // ERROR CODES-------------
                // <success> - The credentials are accepted by MySQL and user is created
                // <error> - Any other error(Including existing credentials. This is to protect user data)
                // -----------------------
                //
                // Button is set to normal
                if (text == "<success>") {
                    // If MySQL accepted the data and created the new entry, this is called
                    // It sets the message text to be success and redirects automatically
                    // to the mail page with the email address in ?email= parameter
                    // so that it automatically sends the verification email.
                    // Check mail section for more details
                    //
                    buttonElement.classList.remove("form__button--loading");
                    buttonElement.disabled = true;
                    setFormMessage(signupForm, "success", "Successfully logged in.");
                    window.location.replace("../signup");
                } else {
                    // On error recieved, the error message is displayed
                    buttonElement.classList.remove("form__button--loading");
                    buttonElement.disabled = false;
                    setFormMessage(signupForm, "error", text);
                }
            }).catch(function(error) {
                // In case JS encountered an error, this message is shown
                setFormMessage(signupForm, "error", "Oops! Something went wrong. Please reload the page.");
            })
        } else {
            // In case the entered doesn't match criteria, show this error [Defined in documents]
            buttonElement.classList.remove("form__button--loading");
            buttonElement.disabled = false;
            setFormMessage(signupForm, "error", "Invalid credentials");
        }
    });

    document.querySelectorAll(".form__input").forEach(inputElement => {
        // On changing text in any of the input fields of signup fiends
        // Note: This function checks errors in entered parameters real time. This check is performed at submission too
        // but this way we also provide the user with real time instructions to fix errors.
        //
        inputElement.addEventListener("blur", e => {
            if (e.target.id === "signupUsername" && e.target.value.length < 5) {
                setIputError(signupForm, "Username must be at least 5 characters in length");
            }
            if (e.target.id === "signupUsername" && (e.target.value.includes("<") || e.target.value.includes(">"))) {
                setIputError(signupForm, "Username must not contain <>");
            }
            if ((e.target.id === "signupEmail") && (!e.target.value.includes("@") || (e.target.value.includes(">") || e.target.value.includes("<")) || e.target.value.length < 5)) {
                setIputError(signupForm, "You have entered an invalid email");
            }
            if ((e.target.id === "signupPassword") && !isAllPresent(e.target.value) || e.target.value.includes(">") || e.target.value.includes("<")) {
                setIputError(signupForm, "Password should contain at least one Uppercase letter and number (except <>) and should be between 8 to 20 characters long");
            }
        });

        inputElement.addEventListener("input", e => {
            clearInputError(signupForm);
            clearInputError(loginForm);
        })
    })
});

// End of event listeners. Start of functions.
/////////////////////////////////////////////////////////////////////////

function setFormMessage(formElement, type, message) {
    // Sets the message of the form. This is the overll message, not input suggestions
    // [Check the .form__input event listener for information]
    // Accepts the (HTML element)formElement, type of error as (string)type and (string)message
    // Note: Type can be only 'success'(Displays green text) or 'error'(Displays red text)
    // Returns null
    //
    const messageElement = formElement.querySelector(".form__message");
    const buttonElement = formElement.querySelector(".form__button");

    messageElement.textContent = message;
    messageElement.classList.remove("form__message--success", "form__message--error");
    messageElement.classList.add(`form__message--${type}`);
    buttonElement.disabled = false;
}

function setIputError(formElement, message) {
    // Sets the message of the form for input suggestions
    // [Check the .form__input event listener for information]
    // Accepts the (HTML element)formElement and (string)message
    // Returns null
    //
    const messageElement = formElement.querySelector(".form__message");
    const buttonElement = formElement.querySelector(".form__button");

    messageElement.textContent = message;
    messageElement.classList.remove("form__message--success", "form__message--error");
    messageElement.classList.add("form__message--error");
    buttonElement.disabled = true;
}

function clearInputError(formElement) {
    // Removes any messages present on the form message section
    // Accepts the (HTML element)formElement
    // Returns null
    //
    const messageElement = formElement.querySelector(".form__message");
    const buttonElement = formElement.querySelector(".form__button");

    messageElement.textContent = "";
    messageElement.classList.remove("form__message--success", "form__message--error");
    messageElement.classList.remove("form__message--error");
    buttonElement.disabled = false;
}

function checkUsername(str) {
    // Checking the username
    return (str.length > 5 && !str.includes("<") && !str.includes(">"));
}

function checkEmail(str) {
    // Checking the email
    return (str.length > 5 && !str.includes("<") && !str.includes(">") && str.includes("@"));
}

function checkPassword(str) {
    // Checking the password
    return (isAllPresent(str) && !str.includes("<") && !str.includes(">"));
}

function isAllPresent(str) {
    // Check if password fit the password parameters defined:
    //      1 At least 8 characters
    //      2 A mixture of both uppercase and lowercase letters
    //      3 A mixture of letters and numbers
    //      4 At least one special character
    // Note: Check documents for details
    //
    var pattern = new RegExp(
      "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$"
    );

    return (pattern.test(str) && !(!str || str.length < 8 || str.length > 20));
}