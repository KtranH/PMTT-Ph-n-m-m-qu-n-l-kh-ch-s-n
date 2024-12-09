<?php

namespace App\Mail;

use Illuminate\Bus\Queueable;
use Illuminate\Contracts\Queue\ShouldQueue;
use Illuminate\Mail\Mailable;
use Illuminate\Mail\Mailables\Content;
use Illuminate\Mail\Mailables\Envelope;
use Illuminate\Queue\SerializesModels;

class ETicketMail extends Mailable
{
    use Queueable, SerializesModels;

    public $user;
    public $roomType;
    public $checkIn;
    public $checkOut;
    public $payment;
    public $status;
    public $occupant_info;
    public $code;

    /**
     * Create a new message instance.
     */
    public function __construct($user, $roomType, $checkIn, $checkOut, $payment, $status, $occupant_info, $code)
    {
        $this->user = $user;
        $this->roomType = $roomType;
        $this->checkIn = $checkIn;
        $this->checkOut = $checkOut;
        $this->payment = $payment;
        $this->status = $status;
        $this->occupant_info = $occupant_info;
        $this->code = $code;
    }

    /**
     * Get the message envelope.
     */
    public function envelope(): Envelope
    {
        return new Envelope(
            subject: 'Vé điện tử xác nhận đặt phòng',
        );
    }

    /**
     * Get the message content definition.
     */
    public function content(): Content
    {
        return new Content(
            view: 'MailController.ETicketEmail',
        );
    }

    /**
     * Get the attachments for the message.
     *
     * @return array<int, \Illuminate\Mail\Mailables\Attachment>
     */
    public function attachments(): array
    {
        return [];
    }
}
