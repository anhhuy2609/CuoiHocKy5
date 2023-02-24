<h3>Thêm bảo dưỡng</h3>
<form action="thembaoduong.php" method="POST">
    Số xe <input type="text" name="soxe" id="soxe" placeholder="51H-XXX.XX">
    Họ tên khách hàng <input type="text" name="makhachhang" id="makhachhang">
    Mã bảo dưỡng <input type="text" name="mabaoduong" placeholder="BD001">
    Số KM <input type="text" name="sokm" placeholder="20000">
    Nội dung <input type="text" name="noidung" placeholder="Bảo dưỡng 20000">
    <input type="submit" value="Thêm">
</form>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.3/jquery.min.js"></script>
<script>
    $(document).ready(function() {
        $("#soxe").change(function() {
            var soxe = $(this).val();
            $.ajax({
               url: "hienthikhachhang.php",
               method: "POST",
               data: {soxe:soxe},
               success: function(data) {
                    $("#makhachhang").val(data);
               } 
            });
        });
    });
</script>
