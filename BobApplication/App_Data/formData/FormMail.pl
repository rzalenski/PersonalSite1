#!/usr/bin/perl -wT
#
# NMS FormMail Version 3.14c1
#

use strict;
use vars qw(
  $DEBUGGING $emulate_matts_code $secure %more_config
  $allow_empty_ref $max_recipients $mailprog @referers
  @allow_mail_to @recipients %recipient_alias
  @valid_ENV $date_fmt $style $send_confirmation_mail
  $confirmation_text $locale $charset $no_content
  $double_spacing $wrap_text $wrap_style $postmaster 
  $address_style
);

BEGIN
{
  $DEBUGGING         = 1;
  $emulate_matts_code= 0;
  $secure            = 1;
  $allow_empty_ref   = 1;
  $max_recipients    = 5;
  $mailprog          = '/usr/lib/sendmail -oi -t';
  $postmaster        = '';
  @referers          = qw(http://people.consolidated.net/zalenski);
  @allow_mail_to     = qw(bob.zalenski@gmail.com);
  @recipients        = ();
  %recipient_alias   = ();
  @valid_ENV         = qw(REMOTE_HOST REMOTE_ADDR REMOTE_USER HTTP_USER_AGENT);
  $locale            = '';
  $charset           = 'iso-8859-1';
  $date_fmt          = '%A, %B %d, %Y at %H:%M:%S';
  $style             = '/css/nms.css';
  $no_content        = 0;
  $double_spacing    = 1;
  $wrap_text         = 0;
  $wrap_style        = 1;
  $address_style     = 0;
  $send_confirmation_mail = 0;
  $confirmation_text = <<'END_OF_CONFIRMATION';
From: bob.zalenski@gmail.com
Subject: Website Comment

Thank you for your form submission.

END_OF_CONFIRMATION

}
