<h3>Thanh toán</h3>
<form action="thanhtoan.php" method = "POST">
    Số xe <select name="mabaoduong" id="soxe"></select>
    Ngày nhận xe <input type="date" name="ngaynhanxe" id="ngaynhanxe">
    Thành tiền <input type="text" name="thanhtien" id="thanhtien">
    <div class="hienthicongviec"></div>
    <input type="submit" value="Thanh toán">
</form>

<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.3/jquery.min.js"></script>
<script>
    $(document).ready(function() {
        $("input[type=date]").change(function() {
            var ngaynhan = $(this).val();
            $.ajax({
                url: "hienthisoxe.php",
                method: "POST",
                data: {ngaynhan:ngaynhan},
                success: function(data) {
                    $("#soxe").html(data);
                }
            });
        });

        $("#soxe").on("change",function(){
            var mabaoduong = $(this).val();
            $.ajax({
                url: "hienthicongviec.php",
                method: "POST",
                data: {mabaoduong:mabaoduong},
                success: function(data) {
                    $(".hienthicongviec").html(data);
                    var sum = 0;
                    $(".dongia").each(function() {
                        sum += Number($(this).text());
                    });
                    $("#thanhtien").val(sum);
                }
            });
        });

        $("body").on("click", ".btn-delete", function(){
            var row = $(this).parents("tr");
            var macv = row.find(".macv").val();
            var mabd = $("#soxe").val();
            $.ajax({
                url:"xoacongviec.php",
                method: "POST",
                data: {macv: macv, mabd: mabd},
                success: function() {
                    row.remove();
                    // var sum = 0;
                    // $(".dongia").each(function() {
                    //     sum += Number($(this).text());
                    // });
                    // $("#thanhtien").val(sum);
                }
            });
        });
    });
</script>