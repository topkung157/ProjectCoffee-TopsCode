<?php  include('server.php')?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Login Page</title>
    <link rle="stylesheet" href="css/style.css">
</head>
<body>
    <div class="header">
        <h2>Login</h2>
    </div>
    <form action="login_db.php" method="post">
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
            <label for="password">Password</label>
            <input type="password" name="password">
        </div>
        <div class="input-group">
            <label for="username">Username</label>
            <button type="submit" name="login_user" class="btn">Login</button></button>
        </div>
        <p>Not yet memcer? <a href="register.php"></a>Sign up</a></p>
    </form>
</body>
</html> 