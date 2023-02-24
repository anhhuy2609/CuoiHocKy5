<?php 
    include "connect.php";
    $soxe = $_POST['soxe'];
    $mabaoduong = $_POST['mabaoduong'];
    $sokm = $_POST['sokm'];
    $noidung = $_POST['noidung'];
    $ngaynhan = date("Y-m-d");
    $sql = "INSERT INTO BAODUONG VALUES ('$mabaoduong', '$ngaynhan', null, '$sokm', '$noidung', '$soxe', null)";
    if($connect->query($sql)){
        echo "Thêm thành công";
    }
    $connect->close();
?>