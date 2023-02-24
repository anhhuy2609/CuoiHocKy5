<?php 
    include "connect.php";
    $makhachhang = $_POST['makhachhang'];
    $tenkhachhang = $_POST['tenkhachhang'];
    $diachi = $_POST['diachi'];
    $dienthoai = $_POST['dienthoai'];
    $sql = "INSERT INTO KHACHHANG VALUES ('$makhachhang','$tenkhachhang','$diachi', '$dienthoai')";
    $connect->query($sql);
?>