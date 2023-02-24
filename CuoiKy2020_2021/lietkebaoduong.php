<?php
    include "connect.php";
    $solanbd = $_POST['solanbd'];
    $sql = "SELECT HOTENKH, X.SOXE, COUNT(*) FROM BAODUONG B, XE X, KHACHHANG K WHERE B.SOXE = X.SOXE AND X.MAKH = K.MAKH GROUP BY HOTENKH, SOXE HAVING COUNT(*) > '$solanbd'";
    $result = $connect->query($sql);
    echo "
        <table border = '1'>
            <tr> 
                <th>Họ tên khách hàng</th>
                <th>Số xe</th>
                <th>Số lần bảo dưỡng</th>
            </tr> 
    ";
    while($row = $result->fetch_row()){
        echo "
        <tr>
            <td> $row[0]</td>
            <td> $row[1]</td>
            <td> $row[2]</td>
        </tr>
        ";
    }
    echo "</table>";
?>