// A mock market-analysis tool with a penchant for the number 42

class DeepThought {
    runMarketAnalysis() {
        let analysisFunc = this.runMarketAnalysisSync;
        return new Promise((rs) => {
            setTimeout(rs(analysisFunc()), 4000);
        });
    }

    runMarketAnalysisSync() {
        // Okay so the inputs are never used, it's a mock-tool after all!

        let orderType = [
            'Limit Order',
            'Market Order'
        ][Math.floor(Math.random() * 2)];

        let orderAction = [
            'Sell',
            'Buy'
        ][Math.floor(Math.random() * 2)];

        let security = [
            'APPL',
            'IBM',
            'MSFT',
            'CSCO',
            'SIRI',
            'VOGON'
        ][Math.floor(Math.random() * 6)];

        let shares = [
            4200,
            Math.floor(Math.random() * 10000)
        ][Math.floor(Math.random() * 2)];

        let limit = [
            42.0,
            Math.floor(Math.random() * 42000) / 100
        ][Math.floor(Math.random() * 2)];

        return {
            orderType,
            orderAction,
            security,
            shares,
            limit: orderType === 'Limit Order' ? limit : undefined
        };
    }
}