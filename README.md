# GAME FRAMEWORK

## OVERVIEW

### FSM

#### DIFFERENT FSM MANAGERS

##### MAIN MENU STATE

Manages the pages and areas of the main menu:
- **MainMenuInitialize**
  - OnEnter:
  - Execute: Check for connection to the internet, then show welcome message, then change to MainMenuShowWelcomeState
  - OnExit:
- **MainMenuShowWelcomeState**
  - OnEnter: Show WelcomeScreenPanel.
  - Execute: Check for connection to the internet, then show welcome message. On Pressing Ok, change to MainMenuShowSaveMessageState.
  - OnExit:	Hide WelcomeScreenPanel.
- **MainMenuShowSaveMessageState**
  - OnEnter: Show SaveMessagePanel.
  - Execute: Wait 10 seconds, then change to MainMenuShowMenuState.
  - OnExit: Hide SaveMessagePanel.
- **MainMenuShowMenuState**
  - OnEnter: Show MainMenuPanel.
  - Execute: Wait for input to either change to Options, Extras, or change to MainMenuStartGameState when going to Continue or New Game.
  - OnExit: Hide MainMenuPanel.
- **MainMenuStartGameState**
  - OnEnter: Show GamePanel
  - Exectute: Wait for selection.
  - OnExit: Hide GamePanel
- **MainMenuShowOptionsState**
  - OnEnter:
  - Execute:
  - OnExit:
- **MainMenuShowExtrasOptions**
  - OnEnter:
  - Execute:
  - OnExit:

##### GAME LOADING STATE

Manages the current Loading state:
- **LoadingStartState**
  - OnEnter:
  - Execute:
  - OnExit:
- **LoadingState**
  - OnEnter:
  - Execute:
  - OnExit:
- **LoadingSceneState**
  - OnEnter:
  - Execute:
  - OnExit:
- **LoadingSetupState**
  - OnEnter:
  - Execute:
  - OnExit:
- **LoadingFinishedState**
  - OnEnter:
  - Execute:
  - OnExit:

##### GAME STATE

Manages the current Game State:
- **GamePrepareState**
  - OnEnter:
  - Execute:
  - OnExit:
- **GameMenuState**
  - OnEnter:
  - Execute:
  - OnExit:
- **GameRunningState**
  - OnEnter:
  - Execute:
  - OnExit:
- **GamePauseState**
  - OnEnter:
  - Execute:
  - OnExit:

