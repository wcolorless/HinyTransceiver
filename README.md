# HinyTransceiver
Hiny is designed to build distributed (service-oriented) systems. It is designed so that you need to create a service class. This class will be adopted by Hiny to create an object. Object methods accept requests from the client. Hiny serializes the request object on the client side and deserializes on the server side. Next, a request is extracted which represents the arguments of the function and passed to the target method of the service. The result that returned the method of the service object is serialized as a response and transmitted to the client.

[Go to the wiki section for more information.](https://github.com/wcolorless/HinyTransceiver/wiki)
