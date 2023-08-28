
// Function #1: validate input and sort into appropriate list
function validateInputAddToListFunc() {
    // ---- variables ----
    const StringEnterBox: string = (<HTMLInputElement>document.getElementById("StringEnterBox")).value;
    const myListItem: HTMLInputElement = (<HTMLInputElement>document.getElementById("myList1"));
    const liNode: HTMLElement = document.createElement("li");

    // ---- validate response, place into list ----
    if (StringEnterBox == "") {
        alert("Please enter a word or number to check");
    } else {
        liNode.setAttribute('id', StringEnterBox);
        liNode.appendChild(document.createTextNode(StringEnterBox));
        myListItem.appendChild(liNode);
    }
}

// Function #2: remove item from list
function validateInputRemoveFromListFunc() {
    // ---- variables ----
    const StringEnterBox = document.getElementById("StringEnterBox") as HTMLInputElement;
    const myListItem = document.getElementById("myList1") as HTMLInputElement;
    const itemToRemove = document.getElementById(StringEnterBox.value) as HTMLInputElement;

    // ---- validate response, place into list ----
    if (StringEnterBox.value == "") {
        alert("Please enter a word or number to check");
    } else {
        myListItem.removeChild(itemToRemove);
    }
}



// Function #3: clear list
function resetListsFunc() {
    // ---- variables ----
    const myListItem = document.getElementById("myList1") as HTMLInputElement;

    myListItem.innerHTML = "";
    alert("lists have been reset");
}




// // Function #2: remove item from list
// function validateInputRemoveFromListFunc() {
//     // ---- variables ----
//     const StringEnterBox = document.getElementById("StringEnterBox") as HTMLInputElement;
//     const myListItem = document.getElementById("myList1") as HTMLInputElement;
//     const itemToRemove = document.getElementById(StringEnterBox.value) as HTMLInputElement;

//     // ---- validate response, place into list ----
//     if (StringEnterBox.value == "") {
//         alert("Please enter a word or number to check");
//     } else {
//         if (itemToRemove != null) {
//             myListItem.removeChild(itemToRemove);
//         }
//     }
// }




