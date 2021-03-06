package com.mygdx.fbhelpers;

import com.badlogic.gdx.InputProcessor;
import com.mygdx.gameobjects.Bird;
import com.mygdx.gameworld.GameWorld;
import com.mygdx.button.Button;

public class InputHandler implements InputProcessor {
	private Bird bird;
	private GameWorld world;
	private Button play;
	private float scaleX;
	private float scaleY;

	public InputHandler(GameWorld world, float scaleX, float scaleY) {
		this.world = world;
		bird = world.getBird();
		int yMidPoint = world.getYMidPoint();
		this.scaleX = scaleX;
		this.scaleY = scaleY;
		play = new Button(82 - (AssetLoader.startButton.getRegionWidth() / 2), yMidPoint + 25, 29, 16, AssetLoader.startButton);
	}

	@Override
	public boolean touchDown(int screenX, int screenY, int pointer, int button) {
		screenX = scaleX(screenX);
		screenY = scaleY(screenY);
		if (world.isMenu()) {
			play.isTouchDown(screenX, screenY);
		}
		else if (world.isReady()) {
			world.start();
			bird.onClick();
		}
		else if (world.isRunning()) {
			bird.onClick();
		}
		
		if (world.isGameOver() || world.isHighScore()) {
			world.restart();
		}
		return true;
	}

	@Override
	public boolean touchUp(int screenX, int screenY, int pointer, int button) {
		screenX = scaleX(screenX);
		screenY = scaleY(screenY);
		if (world.isMenu()) {
			if (play.isTouchUp(screenX, screenY)) {
				world.ready();
				return true;
			}
		}
		return false; 
	}

	private int scaleX(int screenX) {
		return (int) (screenX / scaleX);
	}

	private int scaleY(int screenY) {
		return (int) (screenY / scaleY);
	}

	// Getters, setters, observers
	public Button getStartButton() {
		return play;
	}

	@Override
	public boolean keyDown(int keycode) {
		return false;
	}
	@Override
	public boolean keyUp(int keycode) {
		return false;
	}
	@Override
	public boolean keyTyped(char character) {
		return false;
	}
	@Override
	public boolean touchDragged(int screenX, int screenY, int pointer) {
		return false;
	}
	@Override
	public boolean mouseMoved(int screenX, int screenY) {
		return false;
	}
	@Override
	public boolean scrolled(int amount) {
		return false;
	}
}
