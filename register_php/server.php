<?php

    $servername = "localhost";
    $username = "root";
    $password = "";
    $dbname = "register";
    // create connection
    $conn = mysqli_connect($servername, $username, $password, $dbnam);

    //Chack connection
    if (!$conn){
        die("Connection failed" . mysqli_connect_error());
    }
    


?>