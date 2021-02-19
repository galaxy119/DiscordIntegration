﻿// -----------------------------------------------------------------------
// <copyright file="Language.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace DiscordIntegration.API
{
    using System;
    using System.IO;
    using Exiled.API.Features;
    using Newtonsoft.Json;
    using static DiscordIntegration;

    /// <summary>
    /// Represents the plugin language.
    /// </summary>
    [JsonObject(ItemRequired = Required.Always)]
    public sealed class Language
    {
        private readonly JsonSerializer jsonSerializer = new JsonSerializer();

        /// <summary>
        /// Initializes a new instance of the <see cref="Language"/> class.
        /// </summary>
        public Language()
        {
            jsonSerializer.Error += Error;
            jsonSerializer.Formatting = Formatting.Indented;
        }

        /// <summary>
        /// Gets the language folder.
        /// </summary>
        public static string Folder { get; } = Path.Combine(Paths.Plugins, Instance.Name, "Language");

        /// <summary>
        /// Gets the language fullpath.
        /// </summary>
        public static string FullPath => Path.Combine(Folder, $"{Instance.Config.Language}.json");

#pragma warning disable SA1600 // Elements should be documented
#pragma warning disable CS1591
        public string UsedCommand { get; set; } = "used command";

        public string NoPlayersOnline { get; set; } = "No players online.";

        public string NoStaffOnline { get; set; } = "No staff online.";

        public string WaitingForPlayers { get; set; } = "Waiting for players...";

        public string RoundStarting { get; set; } = "Round starting";

        public string PlayersInRound { get; set; } = "players in round";

        public string RoundEnded { get; set; } = "Round ended";

        public string PlayersOnline { get; set; } = "Players online: {0}/{1}";

        public string RoundDuration { get; set; } = "Round duration: {0}";

        public string AliveHumans { get; set; } = "Alive humans: {0}";

        public string AliveScps { get; set; } = "Alive SCPs: {0}";

        public string CheaterReportFilled { get; set; } = "Cheater report filled";

        public string Reported { get; set; } = "reported";

        public string For { get; set; } = "for";

        public string With { get; set; } = "with";

        public string Damaged { get; set; } = "damaged";

        public string Killed { get; set; } = "killed";

        public string ThrewAGrenade { get; set; } = "threw a grenade";

        public string UsedA { get; set; } = "used a";

        public string HasBenChangedToA { get; set; } = "has been changed to a";

        public string ChaosInsurgency { get; set; } = "Chaos Insurgency";

        public string NineTailedFox { get; set; } = "Nine-Tailed Fox";

        public string HasSpawnedWith { get; set; } = "has spawned with";

        public string Players { get; set; } = "players";

        public string HasJoinedTheGame { get; set; } = "has joined the game";

        public string HasBeenFreedBy { get; set; } = "has been freed by";

        public string HasBeenHandcuffedBy { get; set; } = "has been handcuffed by";

        public string WasBannedBy { get; set; } = "was banned by";

        public string HasStartedUsingTheIntercom { get; set; } = "has started using the intercom";

        public string HasPickedUp { get; set; } = "has picked up";

        public string HasDropped { get; set; } = "has dropped";

        public string DecontaminationHasBegun { get; set; } = "Deconamination has begun";

        public string HasRunClientConsoleCommand { get; set; } = "has run a client-console command";

        public string HasEnteredPocketDimension { get; set; } = "has entered the pocket dimension";

        public string HasEscapedPocketDimension { get; set; } = "has escaped the pocket dimension";

        public string HasTriggeredATeslaGate { get; set; } = "has triggered a tesla gate";

        public string Scp914HasProcessedTheFollowingPlayers { get; set; } = "SCP-914 has processed the following players";

        public string AndItems { get; set; } = "and items";

        public string HasClosedADoor { get; set; } = "has closed a door";

        public string HasOpenedADoor { get; set; } = "has opened a door";

        public string Scp914HasBeenActivated { get; set; } = "has activated SCP-914 on setting";

        public string Scp914KnobSettingChanged { get; set; } = "has changed the SCP-914 knob to";

        public string CancelledWarhead { get; set; } = "has cancelled the warhead";

        public string WarheadHasDetonated { get; set; } = "**The Alpha-warhead has detonated**.";

        public string WarheadHasBeenDetonated { get; set; } = "Warhead has been detonated.";

        public string WarheadIsCoutingToDetonation { get; set; } = "Warhead is counting down to detonation.";

        public string WarheadHasntBeenDetonated { get; set; } = "Warhead has not been detonated.";

        public string PlayerWarheadStarted { get; set; } = "{0} ({1}) started the alpha-warhead countdown, detonation in:";

        public string WarheadStarted { get; set; } = "Alpha-warhead countdown initiated, detonation in:";

        public string AccessedWarhead { get; set; } = "has accessed the Alpha-warhead detonation button cover";

        public string CalledElevator { get; set; } = "has called an elevator";

        public string UsedLocker { get; set; } = "has opened a locker";

        public string TriggeredTesla { get; set; } = "has triggered a tesla gate";

        public string GeneratorClosed { get; set; } = "has closed a generator";

        public string GeneratorOpened { get; set; } = "has opened a generator";

        public string GeneratorEjected { get; set; } = "has ejected a tablet from a generator";

        public string GeneratorFinished { get; set; } = "Generator in {0} has finished it's charge up, {1} generators have been activated";

        public string GeneratorInserted { get; set; } = "has inserted a tablet into a generator";

        public string GeneratorUnlocked { get; set; } = "has unlocked a generator door";

        public string WasContained { get; set; } = "has been contained by the Femur Breaker";

        public string CreatedPortal { get; set; } = "has created a portal";

        public string GainedExperience { get; set; } = "has gained experience";

        public string GainedLevel { get; set; } = "has gained a level";

        public string LeftServer { get; set; } = "has left the server";

        public string Reloaded { get; set; } = "has reloaded their weapon";

        public string GroupSet { get; set; } = "has been assigned a group";

        public string ItemChanged { get; set; } = "changed the item in their hand";

        public string InvalidSubcommand { get; set; } = "Invalid subcommand!";

        public string Available { get; set; } = "Available";

        public string BotIsNotConnectedError { get; set; } = "The bot is not connected!";

        public string PlayerListCommandDescription { get; set; } = "Gets the list of players in the server.";

        public string StaffListCommandDescription { get; set; } = "Gets the list of staffers in the server.";

        public string ReloadConfigsCommandDescription { get; set; } = "Reloads bot configs.";

        public string ReloadConfigsCommandSuccess { get; set; } = "Bot configs reload request sent successfully.";

        public string NotEnoughPermissions { get; set; } = "You need \"{0}\" permission to run this command!";

        public string ServerConnected { get; set; } = "```diff\n+ Server connected.\n```";

        public string DisconnectedFromTheBot { get; set; } = "Disconnected from the Bot.";

        public string SendingDataError { get; set; } = "An error has occurred while sending data: {0}";

        public string ReceivingDataError { get; set; } = "An error has occurred while receiving data: {0}";

        public string ConnectingError { get; set; } = "An error has occurred while connecting: {0}";

        public string SuccessfullyConnected { get; set; } = "Successfully connected to {0}:{1}.";

        public string ReceivedData { get; set; } = "Received {0} ({1} bytes) from the server";

        public string SentData { get; set; } = "Sent {0} ({1} bytes) to server.";

        public string ConnectingTo { get; set; } = "Connecting to {0}:{1}";

        public string ReloadLanguageCommandDescription { get; set; } = "Reloads plugin language.";

        public string ReloadLanguageCommandSuccess { get; set; } = "Language reloaded successfully!";

        public string ReloadSyncedRolesSuccess { get; internal set; } = "Bot synced roles reload request sent successfully.";

        public string CouldNotUpdateChannelTopicError { get; set; } = "Error! Couldn't update channel topic: {0}";

        public string InvalidUserGroupError { get; set; } = "Attempted to assign invalid user group \"{0}\" to {1}";

        public string AssigningUserGroupError { get; set; } = "Error assigning user group to {0}, player not found.";

        public string AssingingSyncedGroup { get; set; } = "Assigning synced group \"{0}\" to {1}.";

        public string HandlingQueueError { get; set; } = "Error handling queue: {0}";

        public string HandlingQueueItem { get; set; } = "Handling \"{0}\" with parameters: {1} from {2}";

        public string None { get; set; } = "None";

        public string InvalidParametersError { get; set; } = "You've to insert {0} parameters!";

        public string AddUserCommandDescription { get; set; } = "Adds an userID-discordID pair to the SyncedRole list.";

        public string AddUserCommandSuccess { get; set; } = "User addition request has been sent successfully.";

        public string AddRoleCommandDescription { get; set; } = "Adds a role-group pair to the SyncedRole list.";

        public string AddRoleCommandSuccess { get; set; } = "Role addition request has been sent successfully.";

        public string RemoveUserCommandDescription { get; set; } = "Removes an userID-discordID pair from the SyncedRole list.";

        public string RemoveUserCommandSuccess { get; set; } = "User deletion request has been sent successfully.";

        public string RemoveRoleCommandDescription { get; set; } = "Removes a role-group pair from the SyncedRole list.";

        public string RemoveRoleCommandSuccess { get; set; } = "Role deletion request has been sent successfully.";

        public string ReloadSyncedRolesDescription { get; set; } = "Reloads bot synced roles if connected.";

        public string InvalidDiscordIdError { get; set; } = "{0} is not a valid Discord ID!";

        public string InvalidUserdIdError { get; internal set; } = "{0} is not a valid user ID!";

        public string InvalidDiscordRoleIdError { get; set; } = "{0} is not a valid Discord role ID!";

        public string InvalidGroupError { get; set; } = "{0} is not a valid group!";

        public string ServerHasBeenTerminated { get; set; } = "The server has been terminated.";

        public string ServerHasBeenTerminatedWithErrors { get; set; } = "The server has been terminated with errors: {0}";

        public string WasKicked { get; set; } = "was kicked";

        public string UpdatingConnectionError { get; set; } = "An error has occurred while updating the connection: {0}";

        public string InvalidIPAddress { get; set; } = "{0} is not a valid IP address!";

#pragma warning restore CS1591
#pragma warning restore SA1600 // Elements should be documented

        /// <summary>
        /// Loads the language.
        /// </summary>
        public void Load()
        {
            StreamReader streamReader = new StreamReader(FullPath);

            try
            {
                jsonSerializer.Populate(streamReader, this);
            }
            catch (Exception exception)
            {
                Log.Error($"Error! Failed to read {Instance.Config.Language} language, located at \"{FullPath}\": {exception}.\nDefault translation will be used.");
                return;
            }
            finally
            {
                streamReader?.Dispose();
            }
        }

        /// <summary>
        /// Saves the language.
        /// </summary>
        /// <param name="shouldOverwrite">Indicates a value whether the file should be overwritten or not.</param>
        public void Save(bool shouldOverwrite = false)
        {
            if (File.Exists(FullPath) && !shouldOverwrite)
                return;

            try
            {
                if (!Directory.Exists(Folder))
                    Directory.CreateDirectory(Folder);
            }
            catch (Exception exception)
            {
                Log.Error($"Error! Failed to create language directory at \"{Folder}\": {exception}.");
                return;
            }

            StreamWriter streamWriter = new StreamWriter(FullPath);

            try
            {
                jsonSerializer.Serialize(streamWriter, this);
            }
            catch (Exception exception)
            {
                Log.Error($"Error! Failed to create \"{Instance.Config.Language}\" language at \"{FullPath}\": {exception}.");
                return;
            }
            finally
            {
                streamWriter?.Dispose();
            }
        }

        private void Error(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs ev)
        {
            Log.Warn($"Translation not found for \"{ev.ErrorContext.Member}\" key, loading default one...");

            ev.ErrorContext.Handled = true;
        }
    }
}