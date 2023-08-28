// Function #1: get API Data paragraphs
async function getAPIDataFunc() {

    // -- variables --
    const theApiString: string = (<HTMLInputElement>document.getElementById("StringEnterBox")).value;
    const myp1: HTMLInputElement = (<HTMLInputElement>document.getElementById("myp1"));
    const myp2: HTMLInputElement = (<HTMLInputElement>document.getElementById("myp2"));
    const myp3: HTMLInputElement = (<HTMLInputElement>document.getElementById("myp3"));
    const response: Response = await fetch(theApiString); // api call
    const rawReturn = await response.json();  // read the response
    const jsonString: string = JSON.stringify(rawReturn) // convert reponse to JSON string
    const jsArray = JSON.parse(jsonString) // convert JSON string to js object

    // -- display results, check typeof
    myp1.innerHTML = rawReturn;
    console.log(typeof rawReturn);

    myp2.innerHTML = jsonString;
    console.log(typeof jsonString);

    myp3.innerHTML = jsArray;
    console.log(typeof jsArray);
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