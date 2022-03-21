const express = require('express');

const app = express();
const port = process.env.PORT || 4041;

app.get('/', (_, res) => {
        res.send('hihihi');
});

app.Listen(port, () => {
        console.log('server is running on port: ${port}');
});