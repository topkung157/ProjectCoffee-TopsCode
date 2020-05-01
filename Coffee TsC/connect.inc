<?php
	$conn= mysqli_connect("localhost","root","a0123456789","coffee") or die("Error: " . mysqli_error($con));
	mysqli_query($conn, "SET NAMES 'utf8' "); 
?>