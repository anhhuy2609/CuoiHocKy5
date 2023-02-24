<?php
    include "connect.php";
    $ngaynhan = $_POST['ngaynhan'];
    $sql = "SELECT MABD, SOXE FROM BAODUONG WHERE NGAYGIONHAN = '$ngaynhan'";
    $result = $connect->query($sql);
    while ($row = $result->fetch_row()){
        echo "<option value='$row[0]'> $row[1] </option>";
    }
?>