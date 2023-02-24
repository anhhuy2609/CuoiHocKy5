<?php
    include "connect.php";
    $mabd = $_POST['mabaoduong'];
    $ngaytra  = date("Y-m-d H:i:s");
    $thanhtien = $_POST['thanhtien'];
    $sql = "UPDATE BAODUONG SET NGAYTRA = '$ngaytra', THANHTIEN = '$thanhtien' WHERE MABD = '$mabd'";
    if($connect->query($sql)){
        echo "thanh toan thanh cong";
    }
    $connect->close();
?>