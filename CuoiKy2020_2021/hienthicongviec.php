<?php 
    include "connect.php";
    $mabaoduong = $_POST['mabaoduong'];
    $sql = "SELECT C.MACV, TENCV, DONGIA FROM CONGVIEC C, CT_BD CB WHERE C.MACV = CB.MACV AND MABD = '$mabaoduong'";
    $result = $connect->query($sql);
    echo "
    <table border='1'>
        <tr>
            <th> Tên công việc </th>
            <th> Đơn giá </th>
            <th> Chức năng </th>
        </tr>
    ";
    while ($row = $result->fetch_row()){
        echo "
            <tr>
                 <td> $row[1]</td>
                 <td class = 'dongia'> $row[2]</td>
                 <td> <button type = 'button' class = 'btn-delete'> Xóa </button> </td>
                 <td><input type = 'hidden' value = '$row[0]' class = 'macv' /></td>
             </tr>
        ";   
    }
    echo "</table>";
    $connect->close();
    
?>