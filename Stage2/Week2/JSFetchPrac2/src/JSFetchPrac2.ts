// Function #1: get API Data paragraphs
async function getAPIDataFunc() {

    // ---- variables ----
    const endPointString: string = (<HTMLInputElement>document.getElementById("StringEnterBox")).value;
    const ApiString: string = endPointString;
    const myp1: HTMLInputElement = (<HTMLInputElement>document.getElementById("myp1"));
    const myp2: HTMLInputElement = (<HTMLInputElement>document.getElementById("myp2"));
    const myp3: HTMLInputElement = (<HTMLInputElement>document.getElementById("myp3"));
    const response: Response = await fetch(ApiString); // api call
    const rawReturn = await response.json();  // read the response
    const jsonString: string = JSON.stringify(rawReturn) // convert reponse to JSON string
    const quoteString: string = JSON.stringify(rawReturn.content); // pull the JSON.cotent attribute out
    const authorString: string = JSON.stringify(rawReturn.author); // pull the JSON.author attribute out

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
    const myPItem1: HTMLInputElement = document.getElementById("myp1") as HTMLInputElement;
    const myPItem2: HTMLInputElement = document.getElementById("myp2") as HTMLInputElement;
    const myPItem3: HTMLInputElement = document.getElementById("myp3") as HTMLInputElement;
    myPItem1.innerHTML = "";
    myPItem2.innerHTML = "";
    myPItem3.innerHTML = "";
    alert("Paragraphs have been reset");
}