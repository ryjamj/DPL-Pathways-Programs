"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
function getAPIDataFunc() {
    return __awaiter(this, void 0, void 0, function* () {
        const endPointString = document.getElementById("StringEnterBox").value;
        const integerString = document.getElementById("IntegerEnterBox").value;
        const ApiString = endPointString + "&paras=" + integerString;
        const myp1 = document.getElementById("myp1");
        const myp2 = document.getElementById("myp2");
        const myp3 = document.getElementById("myp3");
        const response = yield fetch(ApiString);
        const rawReturn = yield response.json();
        const jsonString = JSON.stringify(rawReturn);
        const formatedParagrah = JSON.parse(jsonString);
        myp1.innerHTML = rawReturn;
        console.log(typeof rawReturn);
        myp2.innerHTML = jsonString;
        console.log(typeof jsonString);
        for (var para in formatedParagrah) {
            myp3.innerHTML += "<p>" + formatedParagrah[para] + "</p>";
        }
    });
}
function resetParagraphsFunc() {
    const myPItem1 = document.getElementById("myp1");
    const myPItem2 = document.getElementById("myp2");
    const myPItem3 = document.getElementById("myp3");
    myPItem1.innerHTML = "";
    myPItem2.innerHTML = "";
    myPItem3.innerHTML = "";
    alert("Paragraphs have been reset");
}
//# sourceMappingURL=JSFetchPrac.js.map