- IP obtains and defines the address — the IP address — of the application or device the data must be sent to. TCP is then responsible for transporting data and ensuring it gets delivered to the destination application or device that IP has defined.

- TCP, as opposed to User Datagram Protocol (UDP), is a connection-oriented protocol. It establishes a connection between devices before it starts to transmit the data and maintains the connection during the entire conversation duration.

https://miro.medium.com/max/557/1*M7IDta0RXTeafuZ2LIn0iw.png


- Internet Header Length — tell the number of 32-bit words forming the header. if the number is 6, then 6 x 32-bit words are in the header, divide it by 8, i.e. 24 bytes. The maximum size is 15 x 32-bit words which is 60 bytes. The minimum size is 20 bytes or 5 x 32-bit words.

- Type of Service — is how the datagram should be used, for example, delay, precedence, reliability, minimum cost, throughput etc. This TOS field is now used by Differentiated Services and is called the Diff Serv Code Point (DSCP).

- Total Length — is the number of octets that the IP datagram takes up including the header. The maximum size that an IP datagram can be is 65,535 octets.

- Identification — The Identification is a unique number assigned to a datagram fragment to help in the reassembly of fragmented datagrams.

- Flags — Bit 0 is always 0 and is reserved. Bit 1 indicates whether a datagram can be fragmented (0) or not (1). Bit 2 indicates to the receiving unit whether the fragment is the last one in the datagram (1) or if there are still more fragments to come (0).

- Fragment Offset — in units of 8 octets (64 bits) this specifies a value for each data fragment in the reassembly process.

- TTL — the time that the datagram is allowed to exist on the network. A router that processes the packet decrements this by one. Once the value reaches 0, the packet is discarded. This is how ‘Traceroute’ determines the number of hops in a path.

- Protocol — Layer 4 protocol sending the datagram, UDP uses the number 17, TCP uses 6, ICMP uses 1, IGRP uses 88 and OSPF uses 89. Do not confuse this with Port number. That is a different concept.

- Header Checksum — error control for the header only.


- Source Port — The TCP Source Port is the port number used by the computer sending the TCP segment and is usually a number above 1024 (but not always).

- Destination Port — The TCP Destination Port is the port number used by the computer receiving the TCP packet and is usually a number below 1024 (but not always).

- Sequence Number — Used for segmentation of application data into TCP segments and reassembling them on the other side.

- Acknowledgement Number: it is the sequence number of the next byte the receiver expects to receive. The receiver ack’ing sequence number x acknowledges receipt of all data bytes less than (but not including) byte number x. It is worth noting that the sequence number is always valid and the acknowledgement number is only valid when the ACK flag is one. The only time the ACK flag is not set, that is, the only time there is not a valid acknowledgement number in the TCP header, is during the first packet of connection set-up.

- Window — Number of octets in the TCP header

- Checksum — A Cyclic Redundancy Check (CRC) checksum is calculated by the sender and added to this field before transmission. This field is used by the receiver to verify the integrity of the data in the TCP payload and rejects data that fails the CRC check.

- Urgent Pointer — Points to the end of “urgent” data in the packet, but this field only exists if the URG flag is set.

Further, expanding Flag field you can observe different types of TCP flags.

URG
Urgent Flag — Used to inform receiving device that certain data within a segment is urgent.

ACK
Acknowledgement Flag — Used during the 3-way handshake and data transfers.

PSH
Push Flag — Used for TCP push, which returns the buffer to the user application. Used primarily in streaming.

RST
Reset Flag — Used to reset a TCP connection

SYN
Synchronize Flag — Used during the 3-way handshake

FIN
End of data — Indicates the end of the TCP session




