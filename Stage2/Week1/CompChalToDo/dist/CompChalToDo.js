"use strict";
function validateInputAddToListFunc() {
    const StringEnterBox = document.getElementById("StringEnterBox").value;
    const myListItem = document.getElementById("myList1");
    const liNode = document.createElement("li");
    if (StringEnterBox == "") {
        alert("Please enter a word or number to check");
    }
    else {
        liNode.setAttribute('id', StringEnterBox);
        liNode.appendChild(document.createTextNode(StringEnterBox));
        myListItem.appendChild(liNode);
    }
}
function validateInputRemoveFromListFunc() {
    const StringEnterBox = document.getElementById("StringEnterBox");
    const myListItem = document.getElementById("myList1");
    const itemToRemove = document.getElementById(StringEnterBox.value);
    if (StringEnterBox.value == "") {
        alert("Please enter a word or number to check");
    }
    else {
        myListItem.removeChild(itemToRemove);
    }
}
function resetListsFunc() {
    const myListItem = document.getElementById("myList1");
    myListItem.innerHTML = "";
    alert("lists have been reset");
}
//# sourceMappingURL=CompChalToDo.js.map