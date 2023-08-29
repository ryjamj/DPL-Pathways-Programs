"use strict";
// Function #1: get API Data paragraphs
async function getAPIDataFunc() {
    // ---- API ----
    const ApiString = document.getElementById("StringEnterBox").value;
    const response = await fetch(ApiString); // api call
    const rawReturn = await response.json(); // read the response
    // ---- variables ----
    const myp1 = document.getElementById("myp1");
    const myp2 = document.getElementById("myp2");
    const myp3 = document.getElementById("myp3");
    const jsonString = JSON.stringify(rawReturn); // convert API reponse to JSON string
    const quoteString = JSON.stringify(rawReturn.content); // pull the JSON.cotent attribute out
    const authorString = JSON.stringify(rawReturn.author); // pull the JSON.author attribute out
    // ---- display results, check typeof ----
    // output #1
    myp1.innerHTML = jsonString;
    console.log(typeof jsonString);
    // output #2
    myp2.innerHTML = quoteString;
    console.log(typeof quoteString);
    // output #3
    myp3.innerHTML = authorString;
    console.log(typeof authorString);
}
// Function #2: reset paragraphs
function resetParagraphsFunc() {
    const myPItem1 = document.getElementById("myp1");
    const myPItem2 = document.getElementById("myp2");
    const myPItem3 = document.getElementById("myp3");
    myPItem1.innerHTML = "";
    myPItem2.innerHTML = "";
    myPItem3.innerHTML = "";
    alert("Paragraphs have been reset");
}
//# sourceMappingURL=JSFetchPrac2.js.map