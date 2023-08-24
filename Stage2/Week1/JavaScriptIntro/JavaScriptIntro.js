
// Function #1: validate input and sort into appropriate list
function validateInputAddToListFunc() {

    // ---- variables ----
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
        document.getElementById("myList1").appendChild(node); // append the li node to the list
    }
    // place response into int list
    else {
        node.appendChild(textnode); // Append the text entry to the "li" node:
        document.getElementById("myList2").appendChild(node); // append the li node to the list
    }
} // end function


// Function #2: clear the lists
function resetListsFunc() {
    document.getElementById("myList1").innerHTML = "";
    document.getElementById("myList2").innerHTML = "";
    alert("lists have been reset");
} // end function


// create class
class Car {
    constructor(name, year) {
        this.name = name;
        this.year = year;
    }
    ageMeth(x) { // the method()
        return x - this.year;
    }
}

// create object 
const myCar = new Car("Ford", 2014);
document.getElementById("demo").innerHTML = "My car is " + myCar.ageMeth(year) + " years old.";