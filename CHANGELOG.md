# Changelog

## [2.3.0](https://github.com/atc-net/atc-kepware/compare/v2.2.0...v2.3.0) (2026-02-16)


### Features

* **cli:** add meter commands for flow computer drivers ([70e01bd](https://github.com/atc-net/atc-kepware/commit/70e01bd2c1b7f9f2931cdfef72d40284d9d88e5d))


### Bug Fixes

* skip unnecessary API calls in tag group iteration ([4ab82e7](https://github.com/atc-net/atc-kepware/commit/4ab82e7681a2133b9215ccc2b1f5efe209457659))

## [2.2.0](https://github.com/atc-net/atc-kepware/compare/v2.1.0...v2.2.0) (2026-01-30)


### Features

* add Bristol BSAP IP driver support ([#37](https://github.com/atc-net/atc-kepware/issues/37)) ([50995d7](https://github.com/atc-net/atc-kepware/commit/50995d7af89da723fa7a1ad71cb29ed3d86aee54))
* add Busware Ethernet driver support ([#38](https://github.com/atc-net/atc-kepware/issues/38)) ([fbccb99](https://github.com/atc-net/atc-kepware/commit/fbccb99800bb77e8874ba12688cfe4f1be43a8e7))
* add driver support (Mitsubishi CNC/FX Net, Siemens Server, Allen-Bradley) ([60a59bf](https://github.com/atc-net/atc-kepware/commit/60a59bfe772c257649f66e7429bb236298da2a6d))
* add driver support for Alstom, Aromat, AutomationDirect, Beckhoff ([e813d76](https://github.com/atc-net/atc-kepware/commit/e813d76fc870a1c32bad9dee588709d38a2730d2))
* add drivers CODESYS, Cutler-Hammer, Fanuc Focas, Honeywell ([f08bc56](https://github.com/atc-net/atc-kepware/commit/f08bc5646514ba41190cdd2e0274bbdd92218ecd))
* add IEC 60870-5-104 Client and IEC 61850 MMS Client driver support ([08ab91d](https://github.com/atc-net/atc-kepware/commit/08ab91d9e88dd2271195bf20a593082d0a34e70c))
* add meter and meter group support for flow computer drivers ([8bed44d](https://github.com/atc-net/atc-kepware/commit/8bed44d06cd9b3ba9296e806d2eb266ec84193df))
* add missing CLI create commands for drivers ([38dcb75](https://github.com/atc-net/atc-kepware/commit/38dcb75ff8ba7af78124cfa927573b513b2ac7bd))
* add more drivers Allen-Bradley, Custom Interface, DDE Client, Fanuc Focas HSSB, Memory Based, Ping, System Monitor ([7deae39](https://github.com/atc-net/atc-kepware/commit/7deae39857fc91770d19a72c38a30d609e793152))
* add more drivers Keyence, KraussMaffei, MTConnect, OPC XML-DA, Opto 22 ([b62ddfd](https://github.com/atc-net/atc-kepware/commit/b62ddfdbc1e255d76a4270045f99a1bc1eea3335))
* add more drivers SattBus, SIXNET, Torque, Triconex, Yaskawa ([0b6dbff](https://github.com/atc-net/atc-kepware/commit/0b6dbff112c21c43714bb8b9d0a4d0a05f918ef9))
* add remaining Yokogawa Ethernet driver support ([c2b6ef8](https://github.com/atc-net/atc-kepware/commit/c2b6ef80b31b6fd3abc8df7d989acf9325f9183f))
* add Yokogawa Darwin Ethernet driver support ([1d9a3f0](https://github.com/atc-net/atc-kepware/commit/1d9a3f033ac8f38a0442c655d54566f8640ea1ba))
* **cli:** add Allen-Bradley ControlLogix Ethernet CLI commands ([2aa477e](https://github.com/atc-net/atc-kepware/commit/2aa477e0a4f530a95925859612d15552e9d4fe9f))
* **cli:** add Allen-Bradley ControlLogix Server Ethernet CLI commands ([9e411e0](https://github.com/atc-net/atc-kepware/commit/9e411e0cbf46d3d0a4a9cca3523e5e3650cbb527))
* **cli:** add Allen-Bradley Ethernet CLI commands ([6f94029](https://github.com/atc-net/atc-kepware/commit/6f94029880798a2ef2cc9b15df858ba291c38116))
* **cli:** add Allen-Bradley Micro800 Ethernet CLI commands ([cad2399](https://github.com/atc-net/atc-kepware/commit/cad23996460af5dff6d0ab2bc194dc88740f8af3))
* **cli:** add Allen-Bradley Server Ethernet CLI commands ([08fb00c](https://github.com/atc-net/atc-kepware/commit/08fb00c5044aaec84f4488b9dc30996dabe76ff8))
* **cli:** add BACnet/IP CLI commands ([115f5f6](https://github.com/atc-net/atc-kepware/commit/115f5f689686575703ec74a286e95351daf25d8c))
* **cli:** add DNP Client Ethernet CLI commands ([b376ed0](https://github.com/atc-net/atc-kepware/commit/b376ed0496bd9869c4076058f1ceb9cbc11f13a5))
* **cli:** add GE Ethernet CLI commands ([81cb071](https://github.com/atc-net/atc-kepware/commit/81cb071e1a4ce3057bf2b61a7ade5e06a6242847))
* **cli:** add GE Ethernet Global Data CLI commands ([b7b7cd4](https://github.com/atc-net/atc-kepware/commit/b7b7cd485bc823262cfcc3ffa586252b8e712dbc))
* **cli:** add Mitsubishi CNC Ethernet CLI commands ([871dc74](https://github.com/atc-net/atc-kepware/commit/871dc7491d43c1dcff6d46f376788b15ce1ac5d4))
* **cli:** add Mitsubishi Ethernet CLI commands ([a7934db](https://github.com/atc-net/atc-kepware/commit/a7934db4a14d91447c8bd41d35efc0fa089dfc3e))
* **cli:** add Mitsubishi FX Net CLI commands ([93f2e5a](https://github.com/atc-net/atc-kepware/commit/93f2e5ae030c98b445718e207d8d17071e52a51b))
* **cli:** add Modbus TCP/IP Ethernet CLI commands ([23648e6](https://github.com/atc-net/atc-kepware/commit/23648e6810dff22b900c0e5fce9065335b0c81c1))
* **cli:** add MQTT Client CLI commands ([53a4384](https://github.com/atc-net/atc-kepware/commit/53a4384035d6a79d241f8a669915be6ef899cf13))
* **cli:** add Omron FINS Ethernet CLI commands ([5cc2bde](https://github.com/atc-net/atc-kepware/commit/5cc2bde952dfe6c53e28db6c1c4a46a3720e5864))
* **cli:** add Omron NJ Ethernet CLI commands ([361b556](https://github.com/atc-net/atc-kepware/commit/361b55635f93f4424e959fc1c6a3894f7e22003a))
* **cli:** add OPC DA Client CLI commands ([ad5c492](https://github.com/atc-net/atc-kepware/commit/ad5c492f1169e03a5b80cfb76894fca0a046dade))
* **cli:** add Siemens S7 Plus Ethernet CLI commands ([ff46821](https://github.com/atc-net/atc-kepware/commit/ff46821be60c84ea4d7e1e8e29056468964ecab0))
* **cli:** add Siemens TCP/IP Ethernet CLI commands ([3c21723](https://github.com/atc-net/atc-kepware/commit/3c2172362581198ccc4d2c9c6b6294b940e30295))
* **cli:** add Siemens TCP/IP Server Ethernet CLI commands ([dcde4a0](https://github.com/atc-net/atc-kepware/commit/dcde4a0b58933e0e487633b2daf468936e132d52))
* **cli:** add Yokogawa CX Ethernet CLI commands ([046993f](https://github.com/atc-net/atc-kepware/commit/046993f81c9b1b3354ce8a69bbf39fd8c8f95169))
* **configuration:** add Allen-Bradley ControlLogix Ethernet service layer ([e868247](https://github.com/atc-net/atc-kepware/commit/e8682473d3121a4f25807eb350a00c57ddda7606))
* **configuration:** add Allen-Bradley ControlLogix Server Ethernet service layer ([a0da1d8](https://github.com/atc-net/atc-kepware/commit/a0da1d8960c2857379274c5400e05dc46e3ca3d1))
* **configuration:** add Allen-Bradley Ethernet service layer ([0da435b](https://github.com/atc-net/atc-kepware/commit/0da435b11f8051f7779e1ab48771cac626d1bbef))
* **configuration:** add Allen-Bradley Micro800 Ethernet service layer ([a70a6a6](https://github.com/atc-net/atc-kepware/commit/a70a6a674a3b2239017832fdc7e765732e84edb0))
* **configuration:** add Allen-Bradley Server Ethernet service layer ([a152e3b](https://github.com/atc-net/atc-kepware/commit/a152e3b83c260945384ad5a66fbf3480e93adc4d))
* **configuration:** add BACnet/IP service layer ([72e01d6](https://github.com/atc-net/atc-kepware/commit/72e01d696e4ddf171c300d7b7a11ba6da6490529))
* **configuration:** add DNP Client Ethernet service layer ([f83246b](https://github.com/atc-net/atc-kepware/commit/f83246ba66cefea3fda59d1b04651a611ab14513))
* **configuration:** add GE Ethernet Global Data service layer ([525d7a0](https://github.com/atc-net/atc-kepware/commit/525d7a07942d2cc5fa979dc2312d8f133469e4a2))
* **configuration:** add GE Ethernet service layer ([b690ecf](https://github.com/atc-net/atc-kepware/commit/b690ecf0eb5f04d45a68c032c4a516a8f4af2b41))
* **configuration:** add Mitsubishi CNC Ethernet service layer ([716e7ba](https://github.com/atc-net/atc-kepware/commit/716e7ba0083d2942eb1629f9fdf640ff3aaab90a))
* **configuration:** add Mitsubishi Ethernet service layer ([810fd85](https://github.com/atc-net/atc-kepware/commit/810fd850ef130b76249f94b5b812d8151c13785a))
* **configuration:** add Mitsubishi FX Net service layer ([ec31979](https://github.com/atc-net/atc-kepware/commit/ec31979730232d35c6bdb1e2804c52b48b7174c5))
* **configuration:** add Modbus TCP/IP Ethernet service layer ([e2d7ec1](https://github.com/atc-net/atc-kepware/commit/e2d7ec1d3e3bd48d119f13309fe15b42db04da98))
* **configuration:** add MQTT Client service layer ([59bd17a](https://github.com/atc-net/atc-kepware/commit/59bd17a87c7a60096041c5dd34403de7a5f8a10b))
* **configuration:** add Omron FINS Ethernet service layer ([0517f9d](https://github.com/atc-net/atc-kepware/commit/0517f9d70d18ed41baf0a978eaf6aca0645c12f9))
* **configuration:** add Omron NJ Ethernet service layer ([a2faf83](https://github.com/atc-net/atc-kepware/commit/a2faf834cf27f348e7f848f3599a5e8e607302e6))
* **configuration:** add OPC DA Client service layer ([6e09ca4](https://github.com/atc-net/atc-kepware/commit/6e09ca46709b7b07679639a8a570b6bb7690af7d))
* **configuration:** add Siemens S7 Plus Ethernet service layer ([1a55ac7](https://github.com/atc-net/atc-kepware/commit/1a55ac7f9ab7b8b2a50a445281be9bcb03c68733))
* **configuration:** add Siemens TCP/IP Ethernet service layer ([a715cc3](https://github.com/atc-net/atc-kepware/commit/a715cc36488b2a95c6789b9bd4c92e8165afb653))
* **configuration:** add Siemens TCP/IP Server Ethernet service layer ([ef7ba28](https://github.com/atc-net/atc-kepware/commit/ef7ba286df01c37add781ec90b09b4c21198f391))
* **configuration:** add Yokogawa CX Ethernet service layer ([3f1bc22](https://github.com/atc-net/atc-kepware/commit/3f1bc2269dca0a3ae837b292dd1ea7178f519072))
* **contracts:** add Allen-Bradley ControlLogix Ethernet driver support ([92e704f](https://github.com/atc-net/atc-kepware/commit/92e704fae92e37606c1b34154007230fff0ca7ea))
* **contracts:** add Allen-Bradley ControlLogix Server Ethernet driver support ([68b1d36](https://github.com/atc-net/atc-kepware/commit/68b1d368e7fa041b011e7c051905b3f98b348173))
* **contracts:** add Allen-Bradley Ethernet driver support ([ff5f722](https://github.com/atc-net/atc-kepware/commit/ff5f7228afb0ab023d4487ebe1dd613028d22289))
* **contracts:** add Allen-Bradley Micro800 Ethernet driver support ([5756ffa](https://github.com/atc-net/atc-kepware/commit/5756ffa04f62fc8a5480af0acbf4b508d2df8d85))
* **contracts:** add Allen-Bradley Server Ethernet driver support ([f4c60ad](https://github.com/atc-net/atc-kepware/commit/f4c60ade3c71d5834ed59ee06fc4dcdf4e80bc4a))
* **contracts:** add BACnet/IP driver support ([d69f1d5](https://github.com/atc-net/atc-kepware/commit/d69f1d5a5bf1e71f4a4c8faeae6c9ae41a8a91ac))
* **contracts:** add DNP Client Ethernet driver support ([c4f29ac](https://github.com/atc-net/atc-kepware/commit/c4f29ac9b50c7ac7f74c9dea51003a121403ef2b))
* **contracts:** add GE Ethernet driver support ([ccfb742](https://github.com/atc-net/atc-kepware/commit/ccfb7422bf661207c2dd9ae3280d4e7d7177e136))
* **contracts:** add GE Ethernet Global Data driver support ([170fae9](https://github.com/atc-net/atc-kepware/commit/170fae95753822996fc6aa44a6d4a96a483b1300))
* **contracts:** add Mitsubishi CNC Ethernet driver support ([ec08f60](https://github.com/atc-net/atc-kepware/commit/ec08f60f68fff0ed4b2c3d430bd753920861cfa0))
* **contracts:** add Mitsubishi Ethernet driver support ([6c3ce6b](https://github.com/atc-net/atc-kepware/commit/6c3ce6b4ae325cfb7cf1531249d9681cd64997d2))
* **contracts:** add Mitsubishi FX Net driver support ([9472975](https://github.com/atc-net/atc-kepware/commit/9472975475489bef1b7e4604233a6729bd1e64a8))
* **contracts:** add Modbus TCP/IP Ethernet driver support ([aa5b0cd](https://github.com/atc-net/atc-kepware/commit/aa5b0cd0c52710f9fd59da3c9949d20731ce6e2f))
* **contracts:** add MQTT Client driver support ([9503dcd](https://github.com/atc-net/atc-kepware/commit/9503dcd27e3fdd91a9eb9a39dddb4766e013c217))
* **contracts:** add Omron FINS Ethernet driver support ([72a8333](https://github.com/atc-net/atc-kepware/commit/72a83336cab22c2d04bcd025cfc53bb73d44b3ab))
* **contracts:** add Omron NJ Ethernet driver support ([40cfc7b](https://github.com/atc-net/atc-kepware/commit/40cfc7b39b26c9d597230d0eb4c00d920fe9461f))
* **contracts:** add OPC DA Client driver support ([231a6a4](https://github.com/atc-net/atc-kepware/commit/231a6a4d0800f38bbca5ecc5b9c30f2e0be8ec15))
* **contracts:** add Siemens S7 Plus Ethernet driver support ([4c78d86](https://github.com/atc-net/atc-kepware/commit/4c78d8676405ca08b4a602c4bf6b75d910195de7))
* **contracts:** add Siemens TCP/IP Ethernet driver support ([a31c272](https://github.com/atc-net/atc-kepware/commit/a31c2727135ba86e260cacc66fec33a4c9e0e7e5))
* **contracts:** add Siemens TCP/IP Server Ethernet driver support ([f8efed3](https://github.com/atc-net/atc-kepware/commit/f8efed314f267ae39f4bff7ec7d3e302ceffbb74))
* **contracts:** add Yokogawa CX Ethernet driver support ([ab182d3](https://github.com/atc-net/atc-kepware/commit/ab182d371f380499c859f3a8848a56017534fd2e))
* fix all driver bugs - add missing properties and correct defaults ([9652999](https://github.com/atc-net/atc-kepware/commit/96529998bcacd187a39ea0450e40d60dee0c63ac))


### Bug Fixes

* add missing global usings ([b3d5ead](https://github.com/atc-net/atc-kepware/commit/b3d5ead7ed1e803650776d9490858d6961d78bc6))
* **cli:** add CancellationToken to AsyncCommand signatures ([06c57d4](https://github.com/atc-net/atc-kepware/commit/06c57d4a08cff1216c4f0cbd7eceeb0993af27ac))
* SA1518 removing trailing newlines from all affected files ([a72e032](https://github.com/atc-net/atc-kepware/commit/a72e032f5334fa25dbdce2fa35448c63a13be434))

## [2.1.0](https://github.com/atc-net/atc-kepware/compare/v2.0.0...v2.1.0) (2026-01-29)


### Features

* add ServiceCollection extensions for DI registration ([1861b2c](https://github.com/atc-net/atc-kepware/commit/1861b2c805f888e239ff51a4e86f4dcf7656c3f6))
* **iot-gateway:** implement MQTT Client and REST Server agent support ([cd736da](https://github.com/atc-net/atc-kepware/commit/cd736dab0a66bfbca2b291a90cff9cc4fbf85251))
* **sample:** add sample console application ([7d122cc](https://github.com/atc-net/atc-kepware/commit/7d122cc4ba09f38b6c921d091d7a0f54ffa84484))


### Bug Fixes

* **cli:** add CancellationToken to AsyncCommand signatures ([37b4f36](https://github.com/atc-net/atc-kepware/commit/37b4f362d2648c48a9ce357e0e3bb26389cd9a56))
