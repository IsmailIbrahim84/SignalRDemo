import {Injectable} from '@angular/core';
import * as signalR from '@aspnet/signalr';
import {HttpTransportType} from '@aspnet/signalr';

@Injectable( { providedIn: 'root' } )

export class SignalrService {
  constructor() {
  }

  hubconnection: signalR.HubConnection;

  startconnection = () => {
    this.hubconnection = new signalR.HubConnectionBuilder().withUrl('https://localhost:5001/toaster',
      {skipNegotiation: true, transport: HttpTransportType.WebSockets}
    ).build();

    this.hubconnection.start().then(() => {
      console.log('Hub Connection Started');
    }).catch(err => console.log('Error while starting connection: ' + err))

  }
}


