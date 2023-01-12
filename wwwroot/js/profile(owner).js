function editRestaurant() {
    alert("Your information has been saved")
}
function test(clicked) {
    var id = clicked.charAt(clicked.length-1);
    var element = "stat"+id;
    var text = document.getElementById(element);
    text.textContent = "Completed";
}
function addItemToRestaurant(){
    var form = document.getElementById('addItem');
    var table = document.getElementById('itemTable');
    var itemName = form.elements[0];
    var itemPrice = form.elements[1];
    var ID = form.elements[2];
    


    if (itemName.value !="") 
        var row = table.insertRow(1);
        var cell1 = row.insertCell(0);
        var cell2 = row.insertCell(1);
        var cell3 = row.insertCell(2);
        cell1.innerHTML = itemName.value;
        cell2.innerHTML = itemPrice.value;
        cell3.innerHTML = ID.value;

    

}

