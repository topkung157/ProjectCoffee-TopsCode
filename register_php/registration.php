<?php 
    session_start();
    include('server.php');
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Registration</title>
    <link rle="stylesheet" href="css/style.css">
</head>
<body>
    <div class="header">
        <h2>Register</h2>
    </div>
    <form action="register_php"method="post">
        <?php include('errors.php');?>
        <?php if (isset($_SESSION['error'])) : ?>
            <div class="error">
                <h3>
                    <?php 
                        echo $_SESSION['error'];
                        unset($_SESSION['error'])
                    ?>
                </h3>
            </div>
        <?php endif ?>
        <div class="input-group">
            <label for="username">Username</label>
            <input type="text" name="username">
        </div>
        <div class="input-group">
            <label for="Email">Email</label>
            <input type="Email" name="Email">
        </div>
        <div class="input-group">
            <label for="password_1">Password</label>
            <input type="password" name="password">
        </div>
        <div class="input-group">
            <label for="password_2">Confirm Password</label>
            <input type="password" name="password_2">
        </div>
        <div class="input-group">
            <label for="username">Username</label>
            <button type="submit" name="reg_user" class="btn">Register</button></button>
        </div>
        <p>Already a member? <a href="login.php"></a>Sign in</a></p>
    </form>
</body>
</html> 