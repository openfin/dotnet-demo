document.addEventListener('DOMContentLoaded', function () {
    let deepThought = new DeepThought();
    let dataStore = new WeakMap();

    window.dataStore = dataStore;

    document.getElementById('inputA').addEventListener('change', inputChanged);
    document.getElementById('inputB').addEventListener('change', inputChanged);
    document.getElementById('inputC').addEventListener('change', inputChanged);

    let inputs = document.getElementById('inputs');
    let spinner = document.getElementById('thinkingSpinner');
    let results = document.getElementById('results');

    let resultFields = {
        ticker: document.getElementById('resultsTicker'),
        action: document.getElementById('resultsAction'),
        type: document.getElementById('resultsType'),
        shares: document.getElementById('resultsShares'),
        limit: document.getElementById('resultsLimit'),
    };

    inputChanged();

    function inputChanged() {
        showSpinner();
        setTimeout(() => showResults(deepThought.runMarketAnalysisSync()), 2000);
    }

    function showSpinner() {
        inputs.disabled = true;
        spinner.classList.remove('invisible');
        results.classList.add('invisible');
    }

    function showResults(resultData) {
        dataStore.set(results, resultData);

        resultFields.ticker.innerText = resultData.security;
        resultFields.action.innerText = resultData.orderAction;
        resultFields.type.innerText = resultData.orderType;
        resultFields.shares.innerText = resultData.shares;
        resultFields.limit.parentElement.hidden = resultData.limit ? false : true;
        resultFields.limit.innerText = resultData.limit;

        spinner.classList.add('invisible');
        results.classList.remove('invisible');
        inputs.disabled = false;
    }
});