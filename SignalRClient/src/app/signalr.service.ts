import { Injectable } from '@angular/core';
import * as signalR from '@aspnet/signalr';

@Injectable({ providedIn: 'root' })
export class SignalrService {
  constructor(
  ) { }

  hubConnection: signalR.HubConnection;


  startconnection = () => {
    this.hubConnection = new signalR.HubConnectionBuilder().withUrl('https://localhost:5001/toaster',
      {skipNegotiation: true, transport: signalR.HttpTransportType.WebSockets}
    ).build();

    this.hubConnection.start().then(() => {
      console.log('Hub Connection Started');
    }).catch(err => console.log('Error while starting connection: ' + err))

  }

  AskServiceListener() {
this.hubConnection.invoke('AskServer','hey').catch(err => console.log(err));
  }

  AskServer() {
this.hubConnection.on('AskServerResponse',(someText) => {
  console.log(someText);
})
  }
}


