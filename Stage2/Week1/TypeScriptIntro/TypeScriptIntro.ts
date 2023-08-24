
// Function #1: validate input and sort into appropriate list
function validateInputAddToListFunc() {

    // ---- variables ----
    let x : number = 5;
    let StringEnterBoxInput = document.forms["myForm"]["StringEnterBox"].value; // text box input
    const node = document.createElement("li"); // Create an "li" node:
    const textnode = document.createTextNode(StringEnterBoxInput);  // Create a text node:

    // ---- validate response, sort into appropirate list ----
    // no word or number was entered
    if (StringEnterBoxInput == "") {

        alert("Please enter a word or number to check");
    }
    // check if response is not a number, place in string list
    else if (isNaN(StringEnterBoxInput)) {
        node.appendChild(textnode); // Append the text entry to the "li" node:
        document.getElementById("myList1")!.appendChild(node); // append the li node to the list
    }
    // place response into int list
    else {
        node.appendChild(textnode); // Append the text entry to the "li" node:
        document.getElementById("myList2")!.appendChild(node); // append the li node to the list
    }
} // end function


// Function #2: clear the lists
function resetListsFunc() {
    document.getElementById("myList1")!.innerHTML = "";
    document.getElementById("myList2")!.innerHTML = "";
    alert("lists have been reset");
} // end function