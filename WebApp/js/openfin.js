// This code represents added functionality when the application is run in an OpenFin container

document.addEventListener('DOMContentLoaded', function () {
    if (window.fin === undefined) {
        return;
    }

    const dotNetUuid = '8651D4BB-5B58-4AE6-9984-3E6DB1641E7D';
    const processOrderTopic = '1E133889-CCBA-49A8-8898-4E3333526966';

    let openfinFeatures = document.getElementById('openFinFeatures');
    openfinFeatures.classList.remove('invisible');

    let executeOrderButton = document.getElementById('executeOrderButton');
    executeOrderButton.addEventListener('click', executeOrderButtonClick);

    let orderingToolApp = fin.desktop.ExternalApplication.wrap(dotNetUuid);
    orderingToolApp.addEventListener('connected', orderingToolAppConnected);
    orderingToolApp.addEventListener('disconnected', orderingToolAppDisconnected);

    fin.desktop.System.getAllExternalApplications(extApps => {
        let orderToolAppRunning = extApps.findIndex(extApp => extApp.uuid === orderingToolApp.uuid) >= 0;

        if (orderToolAppRunning) {
            orderingToolAppConnected();
        }
    });

    function executeOrderButtonClick() {
        let results = document.getElementById('results');
        let resultsData = window.dataStore.get(results);

        fin.desktop.InterApplicationBus.send(orderingToolApp.uuid, processOrderTopic, resultsData);
    }

    function orderingToolAppConnected() {
        executeOrderButton.disabled = false;
    }

    function orderingToolAppDisconnected() {
        executeOrderButton.disabled = false;
    }
});