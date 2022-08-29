function FetchPeople() {
    $.ajax({
        type: "GET",
        url: "Ajax/FetchData",
        success: function (output) {
            console.log(output);
            document.getElementById("ShowData").innerHTML = output;
        }
    })
}

// id_input1
function GetDetailsOfPerson() {

    var id = document.getElementById("id_input1").value;

    $.ajax({
        type: "POST",
        url: `Ajax/FetchData/${id}`,
        success: function(output) {
            console.log(output);
           
            document.getElementById("ShowData").innerHTML = output;
        }
    })
}

function DeletePerson() {

    var id = document.getElementById("id_input2").value;

    $.ajax({
        type: "POST",
        url: `Ajax/Delete/${id}`,
        success: function (output) {
            if (id != null || id < 1) {
                alert(`A person with id ${id} has successfully been removed.`)
                document.getElementById("ShowData").innerHTML = output;
            } else {
                alert(`Failed to delete person with id ${id}.`)
            }
        },
        error: function (output) {
            alert(`Failed to delete person with id ${id}.`)
        }
    })
}