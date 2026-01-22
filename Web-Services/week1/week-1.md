# Week 1 Web Services Notes

## Process vs Program

Process: instance of a program

Program: static set of instructions, passive process, not running, shutdown

## process types: dependant/cooperating, independent

* dependant/cooperating
  
   can affect or be affected by the execution of another process running on the same or different host. shares data with other processes

* independent 
  
  cannot affect or be affected by the execution of another process. does not share data with any other process

## IPC (Inter-Process Communication)

### methods for effective sharing of information among cooperating processes are collectively known as: IPC

IPC is a mechanism for processes to cooperate, communicate, and synchronize their actions

OS provides IPC API to allow processes to exchange information

### IPC is useful for cooperating processes

Advantages:

* information sharing
* computation speed up
* modularity
* convenience

## IPC MODELS

### Shared Storage

shared memory or shared files. shared ata are directly available to each process in their address spaces

### Message Passing

sockets, pipes, etc. shared data are explicitly exchanged via messages. processes interact with each other through messages with assistance from the OS

### Communication either Synchronous or Asynchronous

* Synchronous

Processes synchronize at every message. both send and receive are blocking operations

* Asynchronous

Send operation is almost always non-blocking

### A port is used as a gateway or entry point into an application

### A socket runs on a specific machine and is bound to a specific port number