<?php
    include "connect.php";
    $macv = $_POST['macv'];
    $mabd = $_POST['mabd'];
    $sql = "DELETE FROM CT_BD WHERE MABD = '$mabd' AND MACV = '$macv'";
    if($connect->query($sql)){
        echo "xoa thanh cong";
    };
    $connect->close();
?>