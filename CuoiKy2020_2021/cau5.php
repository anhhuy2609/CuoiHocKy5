<h3>Liệt kê</h3>

Chọn số lần bảo dưỡng <input type="text" name="solanbd" id="solanbd">

<div id="hienthithongtin"></div>

<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.3/jquery.min.js"></script>

<script>
    $(document).ready(function() {
        $("#solanbd").change(function() {
            var solanbd = $(this).val();
            $.ajax({
                url: "lietkebaoduong.php",
                method: "POST",
                data:{solanbd:solanbd},
                success: function(data) {
                    $("#hienthithongtin").html(data);
                }
            });
        });
    });
</script>