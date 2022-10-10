<?php

    // <!-- This php will handle all the functions related to signup
    // a user sent by the /signup/main.js file. -->

    // <!-- ERROR CODES-------------
    // <success> - The credentials are accepted by MySQL and user is created
    // <error> - Any other error(Including existing credentials. This is to protect user data)
    // ------------------------ -->

    // loading sensitive data
    require_once '../credential.php';
    
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

    $username = $_POST['username']; // Reading the POST data JS sent with 'auth' token
    $email = $_POST['email']; // Reading the POST data JS sent with 'auth' token
    $pword = $_POST['password']; // Reading the POST data JS sent with 'auth' token
    $gender = $_POST['gender']; // Reading the POST data JS sent with 'auth' token
    $vehicleID = $_POST['vehicleID']; // Reading the POST data JS sent with 'auth' token

    // Sanitization
    $email = mysqli_real_escape_string($conn, $email);
    $pword = mysqli_real_escape_string($conn, $pword);
    $username = mysqli_real_escape_string($conn, $username);
    $gender = mysqli_real_escape_string($conn, $gender);
    $vehicleID = mysqli_real_escape_string($conn, $vehicleID);

     // Calling checkEmail function to check if a user already exist
    if (checkEmail($email, $conn)) {
        // If the parameters are valid and unique, account is created
        $error = signup($username, $email, encrypt($pword), $gender, $vehicleID, $conn);
    }
    else
    {
        // Else an error is set to show that the email is already registered
        $error = "This email is already registered.";
    }

    // Closing the connection and dumping the error to POST
    mysqli_close($conn);
    var_dump($error);

    // End of code. Start of function definitions.
    /////////////////////////////////////////////////////////////////////////

    function checkEmail($email, $conn) {
        // Checks if the user exist and is verified
        // Accepts the email as (string)email and connection as (SQL Connection)conn
        // Checks the data returned by SQL query as SQL data and return if the value is equal/not to 0
        // Returns if the user exist{false} as bool
        // Note: 0 means no user exist and the account can be created
        //
        $sql = "SELECT * FROM account WHERE Email='$email'";
        $result = mysqli_query($conn, $sql);
        return (mysqli_num_rows($result) == 0);
    }

    function signup($username, $email, $pword, $gender, $vehicleID, $conn) {
        // The function that execute the SQL query to create the user
        // Accepts the username as (string)username email as (string)email, password as (string)pword,
        // gender as (string)gender and connection as (SQL Connection)conn
        // Returns the error as string
        // Note: Gender must be 0 or 1
        //
        $sql = "INSERT INTO account (email, password, username, gender, vehicle_id)
        VALUES ('$email','$pword','$username','$gender','$vehicleID')"; // SQL query
        // Checking for success
        if (mysqli_query($conn, $sql)) {
            $error = "<success>";
        } else {
            $error = "Error: " . $sql . ":-" . mysqli_error($conn);
        }
        return $error;
    }

    function encrypt($password) {
        // The function that encrypts the password of the user.
        // Accepts the password as (string)password
        // Returns the hash as string
        // Note: This is to protect the users privacy. The BCrypt hash algorithm is used
        // for encryption so that anyone viewing the database has no idea about the password
        return password_hash($password, PASSWORD_BCRYPT);
    }
?>