<?php

    // <!-- This php will handle all the functions related to Voting
    // sent by the /voting/main.js file. -->

    // <!-- ERROR CODES-------------
    // <verified> - The user is verified and credentials are correct. Can log in
    // <notverified> - The user is not verified. Have to show the resend verification link
    // <error> - Any other error(Including wrong credentials. This is to protect user data)
    // ------------------------ -->

    // loading sensitive data
    require_once '../credential.php';

    session_start(); // Starts a session

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
        var_dump($error);
    }

    $params = $_POST['task']; // Accepts the task requested
    $data = $_POST['data']; // Accepts the data sent

    if($params == 'getbooking') {
        // Request to get a random word or a specific word
        $error = getBooking($conn, $data);
    }
    if($params == 'newbooking') {
        // Request to get a random word or a specific word
        $error = newBooking($conn, $data);
    }
    if($params == 'cancelbooking') {
        // Request to get a random word or a specific word
        $error = cancelbooking($conn, $data);
    }
    if($params == 'pendunoccupy') {
        // Request to get a random word or a specific word
        $error = pendunoccupy($conn, $data);
    }
    if($params == 'pendoccupy') {
        // Request to get a random word or a specific word
        $error = pendoccupy($conn, $data);
    }

    // Closing the connection and dumping the error to POST
    echo($error);

    function getBooking($conn, $userID) {
        // Function to get a random word
        // Accept (connection)conn
        // Return the word as array [id, word]
        //
        $returnUser = "";
        $sql = "SELECT booking_id, slot_id, placed_time, booking_date, start_hour, hour_count, status FROM bookings WHERE User_id='$userID' AND (status='0' OR status='1')";
        // User exist
        $result =  mysqli_query($conn, $sql);

        $returnUser = mysqli_fetch_row($result);

        if (mysqli_num_rows($result) == 0) {
            $returnUser = "0";
        } else {
            $returnUser = json_encode($returnUser);
        }

        return $returnUser;
    }

    function newBooking($conn, $data) {
        // Function to get a random word
        // Accept (connection)conn
        // Return the word as array [id, word]
        //
        $returnUser = "";
        $decodedData = json_decode($data, true);
        $user = $decodedData['user'];
        $date = $decodedData['date'];
        $startTime = $decodedData['starttime'];
        $endTime = $decodedData['endtime'];

        $sql = "INSERT INTO `bookings` (`user_id`, `slot_id`, `booking_date`, `start_hour`, `hour_count`) VALUES ('$user', '1', '$date', '$startTime', '$endTime') ";
        // User exist
        $result =  mysqli_query($conn, $sql);

        return $result;
    }

    function cancelBooking($conn, $data) {
        

        $sql = "UPDATE `bookings` SET `status` = '3' WHERE `bookings`.`booking_id` = '$data'";
        // User exist
        $result =  mysqli_query($conn, $sql);

        return $result;
    }

    function pendunoccupy($conn, $data) {
        

        $sql = "UPDATE `bookings` SET `status` = '4' WHERE `bookings`.`booking_id` = '$data'";
        // User exist
        $result =  mysqli_query($conn, $sql);

        return $result;
    }
    function pendoccupy($conn, $data) {
        

        $sql = "UPDATE `bookings` SET `status` = '5' WHERE `bookings`.`booking_id` = '$data'";
        // User exist
        $result =  mysqli_query($conn, $sql);

        return $result;
    }

?>