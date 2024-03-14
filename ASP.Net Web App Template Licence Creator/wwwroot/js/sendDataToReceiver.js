const http = require('http');
console.log('Before sending data to receiver...');

// Ana serverın portunu belirleyin
const sourcePort = 5017;

// Receiver serverının portunu belirleyin
const receiverPort = 5018;

// Ana serverdan JSON verisini alın
http.get(`http://localhost:${sourcePort}`, (res) => {
    let data = '';

    // Chunks of data received
    res.on('data', (chunk) => {
        data += chunk;
    });

    // The whole response has been received
    res.on('end', () => {
        // JSON verisini receiver serverına gönderin
        const options = {
            hostname: 'localhost',
            port: receiverPort,
            path: '/',
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'Content-Length': Buffer.byteLength(data) // Eklendi
            },
        };

        const req = http.request(options, (res) => {
            let responseData = '';

            // Chunks of data received
            res.on('data', (chunk) => {
                responseData += chunk;
            });

            // The whole response has been received
            res.on('end', () => {
                console.log('Receiver serverdan gelen cevap:', responseData);
            });
        });

        req.on('error', (e) => {
            console.error('Sender serverda hata:', e);
        });

        // JSON verisini POST isteği ile gönderin
        req.write(data);
        req.end();
    });
}).on('error', (e) => {
    console.error(`Ana serverda hata: ${e}`);
});
console.log('After sending data to receiver...');
