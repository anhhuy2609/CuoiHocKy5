<?php 
    include "connect.php";
    $makhachhang = $_POST['makhachhang'];
    $soxe = $_POST['soxe'];
    $hangxe = $_POST['hangxe'];
    $namsanxuat = $_POST['namsanxuat'];
    $sql = "INSERT INTO XE VALUES ('$soxe', '$hangxe','$namsanxuat', '$makhachhang')";
    if($connect->query($sql) == true) {
        echo "Thêm thành công";   
    };
    $connect->close();
?>