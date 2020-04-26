<?php
    session_start();
    include('server.php');
    $errors = array();

    if (isset($_POST['reg_user'])) {
        $username = mysqli_real_escape_string($conn, $_POST['username']);
        $Email = mysqli_real_escape_string($conn, $_POST['Email']);
        $password_1 = mysqli_real_escape_string($conn, $_POST['Password_1']);
        $password_2 = mysqli_real_escape_string($conn, $_POST['Password_2']);

        if (empty($username)) {
            array_push($errors, "Username is required");
        }
        if (empty($Email)) {
            array_push($errors, "Email is required");
        }
        if (empty($password_1)) {
            array_push($errors, "Password is required");
        }
        if ($password_1 != $password_2) {
            array_push($errors, "The two passwords do not match");
        }

        $user_check_query = "SELECT * FROM user WHERE username = '$username' OR Email = '$Email' ";
        $query = mysqli_query($conn, $user_check_query);
        $result = mysqli_fetch_assoc($query);

        if ($result) { // if user exists
            if ($result['username'] === $username) {
                array_push($errors, "Username alrea exists");
            }
            if ($result['Email'] === $username) {
                array_push($errors, "Email alrea exists");
            }
        }
        
        if (count($errors) == 0) {
            $password = md5($password_1);
            $sql = "INSERT INTO user (username, email, password) VALUES ('$username','$Email','$password')";
            mysqli_query($conn, $sql);
            $_SESSION['username'] = $username;
            $_SESSION['success'] = "You are now logged in";
            header('location: index.php');    
        }else{
            array_push($errors, "Username or Email already exists ");
            $_SESSION['error'] = "Username or Email already exists!";
            header("location: register.php");
        }
        

    }
?>