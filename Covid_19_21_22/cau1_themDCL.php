<?php
    include "connect.php";
    $madcl = $_POST["madcl"];
    $tendcl = $_POST["tendcl"];
    $diachi = $_POST["diachi"];
    $succhua = $_POST["succhua"];
    $sql = "insert into DiemCachLy values('$madcl', '$tendcl', '$diachi', '$succhua')";
    $result = $connect->query($sql);
    if($result) {
        echo "insert thanh cong";
    } else {
        echo "insert khong thanh cong";
    }
    $connect->close();
?>