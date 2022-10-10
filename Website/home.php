<?php

    // <!-- This php will handle all the functions related to logging in
    // a user sent by the any JS file. -->

    session_start(); // Starts a session

    // Global variables
    $error = "None";
    $params = $_POST['task'];

    // Gives back the username and id if the JS requests
    // Aborts the session if JS requests
    if($params == 'getSession') {
        if (isset($_SESSION['username'])) {
            $error = $_SESSION['username'];
        }
    }else if($params == 'getId') {
        if (isset($_SESSION['id'])) {
            $error = $_SESSION['id'];
        }
    } elseif ($params == 'abortSession') {
        $error = session_destroy();
    }
    // Closing the connection and dumping the error to POST
    echo($error);
?>