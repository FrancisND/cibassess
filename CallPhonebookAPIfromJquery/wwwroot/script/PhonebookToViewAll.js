$(function () {

    var phonebkGlobal;

    const controller = new AbortController();

        getData();

        async function getData() {
            const response = await fetch('https://localhost:44389/api/phonebooks');
            const settings = {
                method: 'get',
                headers: {
                    'Accept': 'application/json, text/plain, */*',
                    'Content-Type': 'application/json'
                }
            };
            const phonebk = await response.json();

            var arrayToString = JSON.stringify(Object.assign({}, phonebk));  // convert array to string
            var stringToJsonObject = JSON.parse(arrayToString);  // convert string to json object

            return stringToJsonObject;
        }

        getData().then(phonebk => {
            phonebk;

            var trHTML = '';
            $.each(phonebk, function (index, value) {
                phonebkGlobal = value.name;
            });

        });

});