
    <h1>Thêm thông tin xe khách hàng</h1>
    <form action="themxe.php" method="POST">
        Họ tên khách hàng <select name="makhachhang">
            <?php 
                include "connect.php";
                $sql = "SELECT * FROM KHACHHANG";
                $result = $connect->query($sql);
                while($row = $result->fetch_row()){
                    echo "<option value = '$row[0]'> $row[1] </option>";
                }
            ?>
        </select><br><br>

        Số xe <input type="text" name="soxe" placeholder="51H-XXX.XX"><br><br>

        Hãng xe <select name="hangxe" id = "hangxe" multiple>
            <option value="Toyota">Toyota</option>
            <option value="BMW">BMW</option>
            <option value="Audi">Audi</option>
        </select><br><br>

        Năm sản xuất <input type="text" name="namsanxuat" placeholder="2020">
        <input type="submit" value="Thêm">

    </form>