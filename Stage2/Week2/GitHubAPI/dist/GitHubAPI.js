"use strict";
// Function #1: get API Data paragraphs
async function getAPIDataFunc() {
    // ---- API ----
    const GiHubIDBoxString = document.getElementById("GiHubIDBox").value;
    const apiString = "https://api.github.com/users/" + GiHubIDBoxString + "/repos";
    const response = await fetch(apiString); // api call
    console.log(apiString);
    console.log("reponse status: ", response.status, " status text: ", response.statusText);
    // ---- variables ----
    let newUserString = "";
    let newReposString = "";
    const userHTML = document.getElementById("theUserNameID");
    const reposHTML = document.getElementById("theReposID");
    // ---- Check reponse Status, populate variables
    if (response.status >= 200 && response.status <= 299) { // 200-299 = valid status
        // a json file- will fetched
        const jsonData = await response.json();
        newUserString = "User Profile: " + jsonData[0].owner.login;
        // create the user feedback with the repos and links
        for (var aRepos in jsonData) {
            newReposString += "<p><a href=" + jsonData[aRepos].html_url + " target=\"_blank\"" + ">" + jsonData[aRepos].name + "</a></p>";
        }
    }
    else { // invalid status, Handle errors
        newUserString = "User Profile: Error, can't find profile";
        newReposString = "Error accessing GitHub, status: " + response.status + ": " + response.statusText;
    }
    // ---- display results, check typeof ----
    // clear what was previously shown
    userHTML.innerHTML = "";
    reposHTML.innerHTML = "";
    // show new info
    userHTML.innerHTML = newUserString;
    reposHTML.innerHTML = newReposString;
}
//# sourceMappingURL=GitHubAPI.js.map