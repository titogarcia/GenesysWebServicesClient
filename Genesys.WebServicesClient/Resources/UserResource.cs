﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genesys.WebServicesClient.Resources
{
    public class UserResource
    {
        public IReadOnlyList<DeviceResource> devices;
    }
}

    //"user": {
    //    "id": "19f413f488814eb9a9fd9fc972b57912",
    //    "userName": "paveld@redwings.com",
    //    "firstName": "Pavel",
    //    "lastName": "Datsyuk",
    //    "roles": ["ROLE_AGENT"],
    //    "devices": [{
    //        "id": "bf78972f-a0f3-44da-9ca6-0a9a7ec5dbea",
    //        "deviceState": "Active",
    //        "userState": {
    //            "id": "0F7F5003-EF26-4D13-A6Ef-D0C7EC819BEB",
    //            "displayName": "Offline",
    //            "state": "LoggedOut"
    //        },
    //        "phoneNumber": "1000",
    //        "e164Number": "1000",
    //        "telephonyNetwork": "Private",
    //        "doNotDisturb": "Off",
    //        "voiceEnvironmentUri": "http://192.168.154.128/api/v2/voice-environments/d0973689-7156-4e84-bfa5-d78f6629d82c",
    //        "capabilities": ["DoNotDisturbOn",
    //        "ForwardCallsOn"]
    //    }],
    //    "skills": [],
    //    "settings": {
    //        "interaction-workspace": {
    //            "voice.prompt-for-end": "false",
    //            "email.from-addresses": "",
    //            "intercommunication.voice.single-step-conference-enabled": "Agent, AgentGroup, RoutingPoint, Contact, TypeDestination",
    //            "expression.phone-number": "^[\\\\(\\\\)\\\\-\\\\.\\\\+\\\\d\\\\s\\\\*#]*[0-9]+[\\\\(\\\\)\\\\-\\\\.\\\\+\\\\d\\\\s\\\\*#]*$",
    //            "intercommunication.chat.routing-based-actions": "OneStepTransfer",
    //            "erro.reply-format": "auto",
    //            "contact.directory-default-mode": "ListView",
    //            "email.quote-char": ">",
    //            "interaction.case-data.content": "History,CaseData",
    //            "login.voice.is-auto-ready": "false",
    //            "statistics.displayed-statistics": "",
    //            "contact.multiple-value-attributes": "PhoneNumber,EmailAddress",
    //            "privilege.teamlead.can-use": "true",
    //            "privilege.voice.can-one-step-transfer": "true",
    //            "teamcommunicator.recent-max-records": "10",
    //            "chat.typing-is-enabled": "true",
    //            "interaction.case-data.frame-color": "#FFBA00",
    //            "chat.agent.text-color": "#385078",
    //            "teamcommunicator.max-suggestion-size": "10",
    //            "privilege.voice.can-send-dtmf": "true",
    //            "contact.default-directory-page-size": "10",
    //            "system.cometd.timeout": "60000",
    //            "chat.prompt-for-done": "false",
    //            "chat.agent.prompt-color": "#385078",
    //            "privilege.voice.show-monitoring.can-use": "true",
    //            "chat.typing-timeout": "10",
    //            "email.html-format": "true",
    //            "facebook.default-queue": "Facebook Outbound Queue",
    //            "alert.timeout": "10",
    //            "chat.pending-response-to-customer": "30,50",
    //            "voice.mark-done-on-release": "false",
    //            "interaction.disposition.use-attached-data": "false",
    //            "intercommunication.voice.routing-points": "",
    //            "intercommunication.voice.routing-based-actions": "MakeCall,OneStepConference,InitConference,OneStepTransfer,InitTransfer",
    //            "teamcommunicator.request-start-timer": "500",
    //            "email.outbound-queue": "",
    //            "system.notif.enabled-websocket": "false",
    //            "facebook.outbound-queue": "Facebook Outbound Queue",
    //            "login.voice.prompt-dn-less-phone-number": "false",
    //            "interaction.disposition.key-name": "DispositionCode",
    //            "chat.auto-answer": "false",
    //            "teamcommunicator.show-all-internal-targets": "false",
    //            "facebook.auto-answer": "false",
    //            "chat.client.text-color": "#166FFF",
    //            "privilege.voice.can-use": "true",
    //            "intercommunication.voice.routing-based-targets": "",
    //            "intercommunication.email.routing-based-actions": "OneStepTransfer",
    //            "email.prompt-for-done": "false",
    //            "email.auto-answer": "false",
    //            "facebook.prompt-for-done": "false",
    //            "contact.displayed-attributes": "Title,FirstName,LastName,PhoneNumber,EmailAddress",
    //            "privilege.voice.can-one-step-conference": "true",
    //            "workbin.email.in-progress": "",
    //            "twitter.auto-answer": "false",
    //            "agent-status.enabled-actions-global": "Ready,NotReady,NotReadyReason,AfterCallWork,Dnd,LogOff",
    //            "privilege.twitter.can-use": "true",
    //            "workbin.facebook.draft": "",
    //            "interaction.web-content": "",
    //            "chat.prompt-for-end": "false",
    //            "privilege.email.can-use": "true",
    //            "contact.cache-timeout-delay": "600",
    //            "chat.time-stamp": "true",
    //            "email.signature.line-<n>": "",
    //            "toast.case-data.content": "History,CaseData",
    //            "workbin.twitter.draft": "",
    //            "privilege.facebook.can-use": "true",
    //            "workbin.twitter.in-progress": "",
    //            "toast.case-data.format-business-attribute": "",
    //            "contact.directory-displayed-columns": "LastName,FirstName,PhoneNumber,EmailAddress",
    //            "contact.directory-search-attributes": "LastName,FirstName,PhoneNumber,EmailAddress",
    //            "workspace.web-content": "",
    //            "workbin.facebook.in-progress": "",
    //            "chat.system.text-color": "#8C8C8C",
    //            "interaction.case-data.format-business-attribute": "",
    //            "application.wiki-help-site": "http://www.genesyslab.info/wiki/",
    //            "contact.available-directory-page-sizes": "5,10,25,50",
    //            "chat.nickname": "$Agent.UserName$",
    //            "intercommunication.email.queue": "",
    //            "presence.evaluate-presence": "false",
    //            "contact.mandatory-attributes": "FirstName,LastName",
    //            "teamcommunicator.corporate-favorites": "",
    //            "facebook.comments-pagination-size": "2",
    //            "interaction.disposition.value-business-attribute": "DispositionCode",
    //            "interaction.disposition.is-read-only-on-idle": "false",
    //            "interaction.override-option-key": "",
    //            "chat.client.prompt-color": "#166FFF",
    //            "intercommunication.chat.queue": "",
    //            "email.quote-header": "On <date>, <contact> wrote:",
    //            "privilege.chat.can-use": "true",
    //            "workbin.email.draft": "",
    //            "interaction.case-data.header-foreground-color": "#15428B",
    //            "interaction.disposition.is-mandatory": "false",
    //            "email.include-original-text-in-reply": "true",
    //            "teamlead.monitoring-scope": "call",
    //            "teamcommunicator.max-size": "50",
    //            "expression.phone-number.supported-characters": "0123456789+",
    //            "intercommunication.chat.routing-based-targets": "",
    //            "case-data.float-separator": ".",
    //            "teamcommunicator.always-clear-textbox-on-new-interaction": "true",
    //            "email.max-attachments-size": "0",
    //            "email.max-attachment-size": "0",
    //            "login.voice.auto-not-ready-reason": "",
    //            "agent-status.enabled-actions-by-channel": "Ready,NotReady,NotReadyReason,AfterCallWork, Dnd, LogOff",
    //            "teamcommunicator.list-filter-showing": "Agent,AgentGroup,RoutingPoint,Skill,Contact",
    //            "intercommunication.email.routing-based-targets": "",
    //            "kpi.displayed-kpis": "",
    //            "chat.enable-auto-disconnect": "true",
    //            "email.reply-prefix": "Re:",
    //            "login.voice.expression.dn-less-phone-number": "",
    //            "email.default-queue": "",
    //            "voice.auto-answer": "false"
    //        },
    //        "htcc": {
    //            "roles": "Agent"
    //        },
    //        "provisioning_flags": {
    //            "modified_At": "5445bb91-9e73-4887-a9a0-17382f043e4f"
    //        }
    //    },
    //    "calls": [],
    //    "changePasswordOnFirstLogin": false
    //}
