using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cocos2d
{
    public class CCMenuItemSprite : CCMenuItem, CCRGBAProtocol
    {
        CCNode m_pNormalImage;
		CCNode m_pSelectedImage;
        CCNode m_pDisabledImage;

        public CCMenuItemSprite()
        { 
            m_pNormalImage      = null;
			m_pSelectedImage    = null;
            m_pDisabledImage    = null;
        }

        /// <summary>
        /// creates a menu item with a normal and selected image
        /// </summary>
        /// <param name="normalSprite"></param>
        /// <param name="selectedSprite"></param>
        /// <returns></returns>
        public static CCMenuItemSprite itemFromNormalSprite(CCNode normalSprite, CCNode selectedSprite)
        { 
            throw new NotImplementedException();        
        }

        /// <summary>
        /// creates a menu item with a normal and selected image with target/selector
        /// </summary>
        /// <param name="normalSprite"></param>
        /// <param name="selectedSprite"></param>
        /// <param name="target"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public static CCMenuItemSprite itemFromNormalSprite(CCNode normalSprite, CCNode selectedSprite, 
                                                        SelectorProtocol target, SEL_MenuHandler selector)
        { 
            throw new NotImplementedException();           
        }

        /// <summary>
        /// creates a menu item with a normal,selected  and disabled image with target/selector
        /// </summary>
        /// <param name="normalSprite"></param>
        /// <param name="selectedSprite"></param>
        /// <param name="disabledSprite"></param>
        /// <param name="target"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public static CCMenuItemSprite itemFromNormalSprite(CCNode normalSprite, CCNode selectedSprite, CCNode disabledSprite,
                                                        SelectorProtocol target, SEL_MenuHandler selector)
        { 
            throw new NotImplementedException();              
        }
        
        /// <summary>
        /// initializes a menu item with a normal, selected  and disabled image with target/selector
        /// </summary>
        /// <param name="normalSprite"></param>
        /// <param name="selectedSprite"></param>
        /// <param name="disabledSprite"></param>
        /// <param name="target"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public bool initFromNormalSprite(CCNode normalSprite, CCNode selectedSprite, CCNode disabledSprite, 
                                    SelectorProtocol target, SEL_MenuHandler selector)
        {
            throw new NotImplementedException();
        }
        
        //// super methods
        public ccColor3B Color { get; set; }

        public byte Opacity { get; set; } // typedef khronos_uint8_t  GLubyte;

        ///**
        //@since v0.99.5
        //*/
        public virtual void selected()
        {
            throw new NotImplementedException();
        }

        public virtual void unselected() 
        {
            throw new NotImplementedException();
        }

        public virtual void setIsEnabled(bool bEnabled)
        {
            throw new NotImplementedException();
        }

        public virtual CCRGBAProtocol convertToRGBAProtocol() 
        { 
            return (this as CCRGBAProtocol); 
        }



        #region Interface CCRGBAProtocol

        byte CCRGBAProtocol.Opacity
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IsOpacityModifyRGB
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}