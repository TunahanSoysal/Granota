function test(clicked) {
    var id = clicked.charAt(clicked.length-1);
    var element = "stat"+id;
    var text = document.getElementById(element);
    text.textContent = "Completed";
}