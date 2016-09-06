
    $(function() {
        var Slider = 0;
        $.Slider = function(toplam) {
            $("#slider ul#buton li").removeClass("aktif");
            $("#slider ul#resim li").hide();
            if (Slider < toplam - 1) {
                Slider++;
                $("#slider ul#buton li:eq(" + Slider + ")").addClass("aktif");
                $("#slider ul#resim li:eq(" + Slider + ")").fadeIn("slow");
            } else {
                $("#slider ul#buton li:first").addClass("aktif");
                $("#slider ul#resim li:first").fadeIn("slow");
                Slider = 0;
            }
        }
        var toplamLi = $("#slider ul#buton li").length;
        var interval = setInterval('$.Slider(' + toplamLi + ')', 3000);
        $("#slider").hover(function() {
            clearInterval(interval);
        }, function() {
            interval = setInterval('$.Slider(' + toplamLi + ')', 3000);
        });
        $("#slider ul#buton li:first ").addClass("aktif");
        $("#slider ul#resim li").hide();
        $("#slider ul#resim li:first").show();
        $("#slider ul#buton li").click(function() {
            var indis = $(this).index();
            $("#slider ul#buton li ").removeClass("aktif");
            $(this).addClass("aktif");
            $("#slider ul#resim li").hide();
            $("#slider ul#resim li:eq(" + indis + ")").fadeIn("slow");
            Slider = indis;
            return false;
        });
    });