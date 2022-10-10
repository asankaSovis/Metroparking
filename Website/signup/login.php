<?php
    // <!-- This php will handle all the functions related to login
    // a user sent by the /signup/main.js file. -->

    // <!-- ERROR CODES-------------
    // <verified> - The user is verified and credentials are correct. Can log in
    // <notverified> - The user is not verified. Have to show the resend verification link
    // <error> - Any other error(Including wrong credentials. This is to protect user data)
    // ------------------------ -->

    // loading sensitive data
    require_once '../credential.php';
    
    session_start();

    // Global variables
    $servername = SERVERNAME;
    $username = USERNAME_SQL;
    $password = PASSWORD_SQL;
    $dbname = DBNAME;
    $error = "None";

    // Creating a connection to the database
    $conn=mysqli_connect($servername,$username,$password,"$dbname");
    if(!$conn) {
        $error = 'Could not Connect MySql Server:' .mysql_error();
    }
    
    $email = $_POST['email']; // Reading the POST data JS sent with 'auth' token
    $pword = $_POST['password']; // Reading the POST data JS sent with 'auth' token

    // Sanitization
    $email = mysqli_real_escape_string($conn, $email);
    $pword = mysqli_real_escape_string($conn, $pword);

    $result = checkEmail($email, $pword, $conn); // Calling checkEmail function to check if parameters are valid

    $value = mysqli_fetch_row($result); // Extracts the username to send to JS back

    // Error handling
    if (mysqli_num_rows($result) == 0) {
        // No users with this credentials
        $error = "Invalid Credentials";
    } else {
        if (password_verify($pword, $value[0])) {
            // Execute the query and validation success
            $error = "<verified>";
            $_SESSION['username'] = $email;
            $_SESSION['id'] = $value[1];
        } else {
            // An error happened
            $error = "Invalid Credentials";
        }
    }

    // Closing the connection and dumping the error to POST
    mysqli_close($conn); 
    var_dump($error); 

    // End of code. Start of function definitions.
    /////////////////////////////////////////////////////////////////////////

    function checkEmail($email, $pword, $conn) {
        // Checks if the user exist and is verified
        // Accepts the email as (string)email, password as (string)pword and connection as (SQL Connection)conn
        // Returns the data returned by SQL query as SQL data
        // Note: The number of rows can be compared to 0 and decide if the user exists
        // Note2: Returned rows contain if they are verified. This can be used to determine if 
        // user is unverified
        //
        $sql = "SELECT password, user_id FROM account WHERE email='$email'";
        // User exist
        return mysqli_query($conn, $sql);
    }
?>