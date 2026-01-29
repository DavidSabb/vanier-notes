# Week 2 Web Services Notes

## Monday Lab - Foundation of the WWW and HTTP

### World Wide Web is a distributed information system that provides access to hypertext documents and other objects

Resources: Standardized term for referring to objects of interest on the Web

Web relies on __client server__ communication model

Standards: Formal standards that define the aspects of the WWW and its related technologies. __eg. UTF8__

### Web Architecture defines 3 guiding principles for working with resources:


* Identification: Resources are __identified__ by Uniform Resource Identifiers __(URI)__
* Formats (Representation): Resources have __represenations__ in different formats

    Media type is a two-part identifier

    * __main type__ represents a general category (text, image, application)
    * __sub type__ identifies the exact kind of data (text/plain, text/html, image/jpeg)


* Interaction: Resources can be interacted with using network protocols (HTTP)

Types of resources: static and dynamic

Static: HTML, CSS, JavaScript, JPEG, PNG, SVG files

Dynamic: Data content generated on demand by programs or scripts

### HTTP Messages defines two types of messages:

* Request Message: Sent from a Web client to a Web server
* Response Message: 

HTTP message consists of 3 parts:

* Start line: First line of the message, indicates what to do for a request
* Header Fields: Zero or more header fields follow the start line, each field consists of a __name/value pair seperated by a colon (:)__
* Body: Actual data of the message, optional. __Request__ bodies carry data to the web server, __response__ bodies carry data back to client

## Wednesday Lecture - 

