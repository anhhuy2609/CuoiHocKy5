<?php 
    include "connect.php";
    $soxe = $_POST['soxe'];
    $sql = "SELECT HOTENKH FROM KHACHHANG K JOIN XE X ON K.MAKH = X.MAKH  WHERE SOXE = '$soxe'";
    $result = $connect->query($sql);
    $row = $result->fetch_row();
    echo $row[0];
    $connect->close();
?>