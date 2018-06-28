﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using ProjectStellar.Library;

namespace ProjectStellar
{
    public class NewGame
    {
        readonly uint _resX;
        readonly uint _resY;
        readonly Game _ctx;
        string _name;
        Text _text;
        RectangleShape _textRectangle;
        Text _confirm;
        FloatRect _confirmBox;
        Text _cancel;
        FloatRect _cancelBox;
        Text _instructions;
        Text _error;

        public NewGame(uint resX, uint resY, Game ctx, Font font)
        {
            _resX = resX;
            _resY = resY;
            _ctx = ctx;
            _name = "";

            _text = new Text("", font)
            {
                Position = new Vector2f(resX / 5 * 2, resY / 5 * 2),
                Color = Color.White
            };

            _textRectangle = new RectangleShape()
            {
                Position = new Vector2f(resX / 2 - (7 * _text.CharacterSize * 0.75f), resY / 5 * 2 + 4),
                Size = new Vector2f(_text.CharacterSize * 14 * 0.7f, _text.CharacterSize),
                FillColor = Color.Black
            };
            
            _confirm = new Text("Confirm", font, 40)
            {
                Position = new Vector2f(resX / 5 * 2, resY / 5 * 3)
            };

            _confirmBox = new FloatRect(_confirm.Position.X + 20, _confirm.Position.Y + 30, _confirm.CharacterSize * _confirm.DisplayedString.Length * 0.75f, _confirm.CharacterSize);

            _cancel = new Text("Cancel", font, 40)
            {
                Position = new Vector2f(resX * 0.05f, resY * 0.05f)
            };

            _cancelBox = new FloatRect(_cancel.Position.X - 10, _cancel.Position.Y + 10, _cancel.CharacterSize * _cancel.DisplayedString.Length * 0.75f, _cancel.CharacterSize);

            _instructions = new Text("Enter the city name :", font, 40)
            {
                Position = new Vector2f(resX / 5 * 1.8f, resY / 5 * 1)
            };

            _error = new Text("", font, 40)
            {
                Position = new Vector2f(resX / 6 * 2, resY / 5 * 4),
                Color = Color.Yellow
            };
        }

        public void Draw(RenderWindow window)
        {
            _instructions.Draw(window, RenderStates.Default);
            
            _textRectangle.Draw(window, RenderStates.Default);

            _text.DisplayedString = _name;
            _text.Position = new Vector2f((_resX / 2) - (_text.DisplayedString.Length / 2 * (_text.CharacterSize * 0.53f)) - 50, _text.Position.Y);
            _text.Draw(window, RenderStates.Default);

            if (_confirmBox.Contains(Mouse.GetPosition(window).X, Mouse.GetPosition(window).Y))
                _confirm.Color = Color.Yellow;
            else _confirm.Color = Color.White;
            _confirm.Draw(window, RenderStates.Default);

            if (_cancelBox.Contains(Mouse.GetPosition(window).X, Mouse.GetPosition(window).Y))
                _cancel.Color = Color.Yellow;
            else _cancel.Color = Color.White;
            _cancel.Draw(window, RenderStates.Default);

            if (_error.DisplayedString != "")
                _error.Draw(window, RenderStates.Default);
        }

        public string Name
        {
            get { return _name; }
            set
            {
                bool valid = true;
                if (value.Length > 12)
                    return;

                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < 'a' || value[i] > 'z')
                    {
                        if (value[i] < 'A' || value[i] > 'Z')
                        {
                            valid = false;
                        }
                    }
                }

                if (valid == true)
                    _name = value;
            }
        }

        public void CheckButtons(int x, int y)
        {
            if (_confirmBox.Contains(x, y) && Name != "")
            {
                List<SaveGameMetadata> saveList = Save.List();
                bool valid = true;

                foreach(SaveGameMetadata save in saveList)
                {
                    if (save.Name == Name)
                    {
                        valid = false;
                        _error.DisplayedString = Name + " already exists !";
                        return;
                    }
                }

                _ctx.StartNewGame();
            }
            else if (_cancelBox.Contains(x, y)) _ctx.MenuState = 0;
        }
    }
}
