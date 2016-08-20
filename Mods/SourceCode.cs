namespace generators {
    
    
    public class court_member_introduced : EventAction {
        
        public override bool Filter() {

		{
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar3 = default(System.Boolean); //IsContext = False IsNew = False
			World StoredVariable0 = root.GetComponent<World>(); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				
				System.Collections.Generic.List<UnityEngine.GameObject> OperandVar2 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
				System.Collections.Generic.List<UnityEngine.GameObject> prop1 = StoredVariable0.Objects; //IsContext = False IsNew = False
				if(prop1 != null)
				{
					OperandVar2 = prop1;
				} else { UnityEngine.Debug.Log("prop1 != null = false " ); }
				
				
				if((  OperandVar2 != null ? OperandVar2.Count : 0) == (  0f))
				{
					applicable = true;
					OperandVar3 = applicable;
				} else { UnityEngine.Debug.Log("(  OperandVar2 != null ? OperandVar2.Count : 0) == (  0f) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable0 != null = false " ); }
			return (System.Boolean) OperandVar3;
		}
        }
        
        public override float Utility() {

		{
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) 1f;
		}
        }
        
        public override void Action() {

		{
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				World subContext4 = root.GetComponent<World>(); //IsContext = True IsNew = False
				
				if(subContext4 != null)
				{
					
					for (int i = 0; i <  5f; i++)
					{
						UnityEngine.GameObject court_member = new UnityEngine.GameObject("court_member"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject court_member5 = court_member; //IsContext = True IsNew = False
							Actor AddContext6 = court_member.AddComponent<Actor>(); //IsContext = True IsNew = True
							Traits AddContext7 = court_member.AddComponent<Traits>(); //IsContext = True IsNew = True
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(court_member);
						UnityEngine.GameObject OperandVar8 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar8 = court_member;
						subContext4.Attach( OperandVar8);
					}
				} else { UnityEngine.Debug.Log("subContext4 != null = false " ); }
			}
		}
        }
    }
    
    public class personality_added : EventAction {
        
        public override bool Filter() {

		{
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar14 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable9 = root.GetComponent<Actor>(); //IsContext = False IsNew = False
			if(StoredVariable9 != null)
			{
				System.Boolean OperandVar13 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar11 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable10 = StoredVariable9.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
				if(StoredVariable10 != null)
				{
					OperandVar11 = StoredVariable10;
				} else { UnityEngine.Debug.Log("StoredVariable10 != null = false " ); }
				System.Boolean prop12 = External.Has( OperandVar11); //IsContext = False IsNew = False
				OperandVar13 = prop12;
				if(!OperandVar13)
				{
					applicable = true;
					OperandVar14 = applicable;
				} else { UnityEngine.Debug.Log("!OperandVar13 = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable9 != null = false " ); }
			return (System.Boolean) OperandVar14;
		}
        }
        
        public override float Utility() {

		{
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) 1f;
		}
        }
        
        public override void Action() {

		{
			UnityEngine.Debug.Log(root);
			
			
			
			Blackboards.personality ContextVar15 = root.AddComponent<Blackboards.personality>();; //IsContext = False IsNew = True
			
			{
				
				if(ContextVar15 != null)
				{
					System.Single OperandVar17 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop16 = External.Random( 0f, 1f); //IsContext = False IsNew = False
					OperandVar17 = prop16;
					ContextVar15.Cruelty =  OperandVar17;
					System.Single OperandVar19 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop18 = External.Random( 0f, 1f); //IsContext = False IsNew = False
					OperandVar19 = prop18;
					ContextVar15.Rationality =  OperandVar19;
					System.Single OperandVar21 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop20 = External.Random( 0f, 1f); //IsContext = False IsNew = False
					OperandVar21 = prop20;
					ContextVar15.Generosity =  OperandVar21;
					System.Single OperandVar23 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop22 = External.Random( 0f, 1f); //IsContext = False IsNew = False
					OperandVar23 = prop22;
					ContextVar15.Zealotry =  OperandVar23;
				} else { UnityEngine.Debug.Log("ContextVar15 != null = false " ); }
			}
		}
        }
    }
    
    public class burn_the_wizard : EventAction {
        
        public override bool Filter() {

		{
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar32 = default(System.Boolean); //IsContext = False IsNew = False
			Actor StoredVariable24 = root.GetComponent<Actor>(); //IsContext = False IsNew = False
			if(StoredVariable24 != null)
			{
				Blackboards.personality StoredVariable25 = StoredVariable24.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
				if(StoredVariable25 != null)
				{
					
					
					System.Single OperandVar27 = default(System.Single); //IsContext = False IsNew = False
					System.Single prop26 = StoredVariable25.Cruelty; //IsContext = False IsNew = False
					OperandVar27 = prop26;
					
					
					
					
					System.Single OperandVar29 = default(System.Single); //IsContext = False IsNew = False
					if(StoredVariable25 != null)
					{
						System.Single prop28 = StoredVariable25.Rationality; //IsContext = False IsNew = False
						OperandVar29 = prop28;
					} else { UnityEngine.Debug.Log("StoredVariable25 != null = false " ); }
					
					
					
					
					System.Single OperandVar31 = default(System.Single); //IsContext = False IsNew = False
					if(StoredVariable25 != null)
					{
						System.Single prop30 = StoredVariable25.Zealotry; //IsContext = False IsNew = False
						OperandVar31 = prop30;
					} else { UnityEngine.Debug.Log("StoredVariable25 != null = false " ); }
					
					
					if(( (  OperandVar27) > (  0.7f)) && ( (  OperandVar29) < (  0.3f)) && ( (  OperandVar31) > (  0.8f)))
					{
						applicable = true;
						OperandVar32 = applicable;
					} else { UnityEngine.Debug.Log("( (  OperandVar27) > (  0.7f)) && ( (  OperandVar29) < (  0.3f)) && ( (  OperandVar31) > (  0.8f)) = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable25 != null = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable24 != null = false " ); }
			return (System.Boolean) OperandVar32;
		}
        }
        
        public override float Utility() {

		{
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			{
				World FuncCtx33 = External.GetWorld();; //IsContext = True IsNew = False
				
				if(FuncCtx33 != null)
				{
					
					{
						Blackboards.events_data subContext34 = FuncCtx33.GetComponent<Blackboards.events_data>(); //IsContext = True IsNew = False
						
						if(subContext34 != null)
						{
							System.Boolean OperandVar38 = default(System.Boolean); //IsContext = False IsNew = False
							UnityEngine.GameObject OperandVar36 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							UnityEngine.GameObject prop35 = subContext34.Wizard; //IsContext = False IsNew = False
							if(prop35 != null)
							{
								OperandVar36 = prop35;
							} else { UnityEngine.Debug.Log("prop35 != null = false " ); }
							System.Boolean prop37 = External.Has( OperandVar36); //IsContext = False IsNew = False
							OperandVar38 = prop37;
							if(!OperandVar38)
							{
								UnityEngine.GameObject OperandVar47 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								System.Collections.Generic.List<UnityEngine.GameObject> OperandVar40 = default(System.Collections.Generic.List<UnityEngine.GameObject>); //IsContext = False IsNew = False
								if(FuncCtx33 != null)
								{
									System.Collections.Generic.List<UnityEngine.GameObject> prop39 = FuncCtx33.Objects; //IsContext = False IsNew = False
									if(prop39 != null)
									{
										OperandVar40 = prop39;
									} else { UnityEngine.Debug.Log("prop39 != null = false " ); }
								} else { UnityEngine.Debug.Log("FuncCtx33 != null = false " ); }
								UnityEngine.GameObject prop46 = External.SelectFrom( OperandVar40,(UnityEngine.GameObject go)=>{;
;
;
System.Single OperandVar43 = default(System.Single); //IsContext = False IsNew = False;
Blackboards.personality StoredVariable41 = go.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False;
if(StoredVariable41 != null)
									{
										System.Single prop42 = StoredVariable41.Rationality; //IsContext = False IsNew = False
										OperandVar43 = prop42;
									} else { UnityEngine.Debug.Log("StoredVariable41 != null = false " ); };
;
;
;
;
;
UnityEngine.GameObject OperandVar44 = default(UnityEngine.GameObject); //IsContext = False IsNew = False;
OperandVar44 = go;;
;
UnityEngine.GameObject OperandVar45 = default(UnityEngine.GameObject); //IsContext = False IsNew = False;
OperandVar45 = root;;
return ( (  OperandVar43) > (  0.7f)) && ( !(  OperandVar44) == (  OperandVar45));}); //IsContext = False IsNew = False
								if(prop46 != null)
								{
									OperandVar47 = prop46;
								} else { UnityEngine.Debug.Log("prop46 != null = false " ); }
								subContext34.Wizard =  OperandVar47;
							} else { UnityEngine.Debug.Log("!OperandVar38 = false " ); }
							System.Boolean OperandVar51 = default(System.Boolean); //IsContext = False IsNew = False
							UnityEngine.GameObject OperandVar49 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							UnityEngine.GameObject prop48 = subContext34.Wizard; //IsContext = False IsNew = False
							if(prop48 != null)
							{
								OperandVar49 = prop48;
							} else { UnityEngine.Debug.Log("prop48 != null = false " ); }
							System.Boolean prop50 = External.Has( OperandVar49); //IsContext = False IsNew = False
							OperandVar51 = prop50;
							if( OperandVar51)
							{
								
								System.Single OperandVar54 = default(System.Single); //IsContext = False IsNew = False
								Blackboards.personality StoredVariable52 = subContext34.GetComponent<Blackboards.personality>(); //IsContext = False IsNew = False
								if(StoredVariable52 != null)
								{
									System.Single prop53 = StoredVariable52.Cruelty; //IsContext = False IsNew = False
									OperandVar54 = prop53;
								} else { UnityEngine.Debug.Log("StoredVariable52 != null = false " ); }
								
								
								System.Single OperandVar56 = default(System.Single); //IsContext = False IsNew = False
								if(StoredVariable52 != null)
								{
									System.Single prop55 = StoredVariable52.Zealotry; //IsContext = False IsNew = False
									OperandVar56 = prop55;
								} else { UnityEngine.Debug.Log("StoredVariable52 != null = false " ); }
								
								ut = ( ( OperandVar54) * ( 0.5f)) + ( ( OperandVar56) * ( 0.5f));
							} else { UnityEngine.Debug.Log(" OperandVar51 = false " ); }
						} else { UnityEngine.Debug.Log("subContext34 != null = false " ); }
					}
				} else { UnityEngine.Debug.Log("FuncCtx33 != null = false " ); }
			}
			return ut;
		}
        }
        
        public override void Action() {

		{
			UnityEngine.Debug.Log(root);
			
			
			
			UnityEngine.GameObject wizard_event = new UnityEngine.GameObject("wizard_event"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject wizard_event57 = wizard_event; //IsContext = True IsNew = False
				Event AddContext58 = wizard_event.AddComponent<Event>(); //IsContext = True IsNew = True
				
				{
					
					if(AddContext58 != null)
					{
						Actor OperandVar60 = default(Actor); //IsContext = False IsNew = False
						Actor StoredVariable59 = root.GetComponent<Actor>(); //IsContext = False IsNew = False
						if(StoredVariable59 != null)
						{
							OperandVar60 = StoredVariable59;
						} else { UnityEngine.Debug.Log("StoredVariable59 != null = false " ); }
						AddContext58.Involved =  OperandVar60;
						Blackboards.burn_event act = wizard_event57.AddComponent<Blackboards.burn_event>();; //IsContext = False IsNew = True
						
						{
							
							if(act != null)
							{
								UnityEngine.GameObject OperandVar64 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								World prop61 = External.GetWorld(); //IsContext = False IsNew = False
								if(prop61 != null)
								{
									Blackboards.events_data StoredVariable62 = prop61.GetComponent<Blackboards.events_data>(); //IsContext = False IsNew = False
									if(StoredVariable62 != null)
									{
										UnityEngine.GameObject prop63 = StoredVariable62.Wizard; //IsContext = False IsNew = False
										if(prop63 != null)
										{
											OperandVar64 = prop63;
										} else { UnityEngine.Debug.Log("prop63 != null = false " ); }
									} else { UnityEngine.Debug.Log("StoredVariable62 != null = false " ); }
								} else { UnityEngine.Debug.Log("prop61 != null = false " ); }
								act.Target =  OperandVar64;
							} else { UnityEngine.Debug.Log("act != null = false " ); }
						}
						Blackboards.burn_event OperandVar65 = default(Blackboards.burn_event); //IsContext = False IsNew = False
						OperandVar65 = act;
						AddContext58.Action =  OperandVar65;
					} else { UnityEngine.Debug.Log("AddContext58 != null = false " ); }
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(wizard_event);
		}
        }
    }
}
