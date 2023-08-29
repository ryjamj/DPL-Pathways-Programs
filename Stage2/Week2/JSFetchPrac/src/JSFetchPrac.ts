// Function #1: get API Data paragraphs
async function getAPIDataFunc() {

    // ---- API ----
    const endPointString: string = (<HTMLInputElement>document.getElementById("StringEnterBox")).value;
    const integerString: string = (<HTMLInputElement>document.getElementById("IntegerEnterBox")).value;
    const ApiString: string = endPointString + "&paras=" + integerString;
    const response: Response = await fetch(ApiString); // api call
    const rawReturn = await response.json();  // read the response

    // ---- variables ----
    const myp1: HTMLInputElement = (<HTMLInputElement>document.getElementById("myp1"));
    const myp2: HTMLInputElement = (<HTMLInputElement>document.getElementById("myp2"));
    const myp3: HTMLInputElement = (<HTMLInputElement>document.getElementById("myp3"));
    const jsonString: string = JSON.stringify(rawReturn) // convert reponse to JSON string
    const formatedParagrah = JSON.parse(jsonString) // convert JSON string to js object

    // ---- display results, check typeof ----
    // output #1
    myp1.innerHTML = rawReturn;
    console.log(typeof rawReturn);
    // output #2
    myp2.innerHTML = jsonString;
    console.log(typeof jsonString);
    // output #3
    for (var para in formatedParagrah) {
        myp3.innerHTML += "<p>" + formatedParagrah[para] + "</p>";
    }
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