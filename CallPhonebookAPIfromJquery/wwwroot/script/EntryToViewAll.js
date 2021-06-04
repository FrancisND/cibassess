$(function () {

    const controller = new AbortController();

    alert("ENTRY !!!");

        getData();

        async function getData() {
            const response = await fetch('https://localhost:44389/api/entries');
            const settings = {
                method: 'get',
                headers: {
                    'Accept': 'application/json, text/plain, */*',
                    'Content-Type': 'application/json'
                }
            };
            const entrybk = await response.json();

            var arrayToString = JSON.stringify(Object.assign({}, entrybk));  // convert array to string
            var stringToJsonObject = JSON.parse(arrayToString);  // convert string to json object

            return stringToJsonObject;
 
        }

        getData().then(entrybk => {
            entrybk;

            //console.log(entrybk.name);
            //var trHTML = '';
            //$.each(entrybk, function (index, value) {
            //    trHTML += '<tr><td>' +  + '<tr><td>' + value.name + '</td></tr>';
            //});
            //$('#table_id').append(trHTML);
            

        });

});